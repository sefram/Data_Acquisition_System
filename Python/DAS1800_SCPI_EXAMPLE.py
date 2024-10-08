"""
    This example show how to interface the Sefram DAS1800 data acquisition system with the SCPI Command.
    The SCPI command works with the Telnet protocol or a TCP/IP RAW socket on the port 23 or 5025.

    To help the development of your script, You can see on the product some log on the page
    Configuration->Remote->SCPI.

    The command use inside this example was tested with the software revision 2.0.2.
    Please upgrade your DAS if you used the previous revision.

"""
import telnetlib
import time

# Timeout on frame receive
TIMEOUT = 5
PORT = 5025


##################### Low level functions #####################

# Remove end of line chars to print
def extractCmd(cmd):
    cmd = cmd.replace("\n", "")
    cmd = cmd.replace("\r", "")
    return cmd


# Send a frame and wait for response
def sendFrame(tn, cmd):
    cmd = cmd + "\n"
    print(">> Send : " + extractCmd(cmd))
    tn.write(cmd.encode('ascii'))
    res = tn.read_until(b'\n', TIMEOUT).decode('ascii')
    if len(res) == 0:
        print("Timeout")
        time.sleep(10)
    else:
        print("<< Rcv  : " + res)
    return res


# Send a frame and wait for response
def sendQuery(tn, cmd):
    cmd = cmd + "\n"
    print(">> Send : " + extractCmd(cmd))
    tn.write(cmd.encode('ascii'))
    res = tn.read_until(b'\n', TIMEOUT).decode('ascii')
    if len(res) == 0:
        print("Timeout")
        time.sleep(10)
    else:
        print("<< Rcv  : " + res)
    return res


def sendCmd(tn, cmd):
    cmd = cmd + "\n"
    print(">> Send : " + extractCmd(cmd))
    tn.write(cmd.encode('ascii'))


class scpi(object):
    '''
    classdocs

    '''

    def __init__(self, ip):
        self.tn = telnetlib.Telnet(ip, PORT, TIMEOUT)

    def runCmd(self, frame):
        if frame.find("?") == -1:
            sendCmd(self.tn, frame)
            time.sleep(0.2)
        else:  # The command contains a ? it's a query
            return sendQuery(self.tn, frame)

    def __del__(self):
        self.tn.close()


"""
    Example of usual command of the DAS1800
"""

if __name__ == "__main__":
    DASIPv4 = "192.168.0.92"

    # IPv4 address of the target DAS
    scpiInst = scpi(DASIPv4)

    '''
        Principal command 
    '''
    # Put the DAS in remote mode
    scpiInst.runCmd('*REM')

    # Getting information of the product connected
    scpiInst.runCmd('*IDN ?')

    # Get the value of all activate measure
    scpiInst.runCmd('RDC?')

    # Get the record state of the DAS
    # Can be : Idle, Waiting for trigger, Recording
    scpiInst.runCmd('REC ?')

    # Start the record
    scpiInst.runCmd('REC ON')
    time.sleep(1)
    # Force the trigger if the DAS is in 'Waiting for trigger' state
    scpiInst.runCmd('REC trig')
    time.sleep(1)
    # Stop the recording
    scpiInst.runCmd('REC OFF')

    # Configuration management
    # Saved the current config in the specified folder /!\ The folder must be already create in the DAS /!\
    # Note: You can specify only the name and the configuration will be saved in the working directory folder
    # You can also store on a USB device connected to the DAS, use the path : /sdb1/...
    scpiInst.runCmd('STORE /internalDisk/my_config.acq_cfg')
    time.sleep(0.2)
    # Load the specified config
    # Note: You can specify only the name if the configuration files are in the working directory folder
    # You can also get the file from a USB device connected to the DAS, use the path : /sdb1/...
    scpiInst.runCmd('RECALL /internalDisk/my_config.acq_cfg')
    # /!\ /!\ You need to wait minimum 20sec to let the software load the configuration /!\/!\
    time.sleep(30)
    # The connection is closed by this command, so we open a new one.
    scpiInst = scpi(DASIPv4)
    # Put the DAS in remote mode
    scpiInst.runCmd('*REM')

    '''
        Secondary command 
    '''

    # Get the hardware option of the device "Battery..." ...
    scpiInst.runCmd('*OPT ?')

    # Get the system date of the product
    scpiInst.runCmd(':DATe ?')
    scpiInst.runCmd(':HOURS ?')

    # Set the name of the record files
    scpiInst.runCmd(':FILE:NAME My_record_file')
    # Get the name of the record files
    scpiInst.runCmd(':FILE:NAME ?')

    # Set the record speed of the first frequency group
    scpiInst.runCmd(':MEMSpeed 1000')
    # Get the record speed of the first frequency group
    scpiInst.runCmd(':MEMSpeed ?')

    # Change the display of the DAS
    # SCOPE , REPLAY , SETUP
    scpiInst.runCmd('SCREEN SCOPE')

    # Put the DAS in Local mode
    scpiInst.runCmd('*LOC')
