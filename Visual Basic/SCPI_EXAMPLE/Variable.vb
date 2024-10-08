Option Strict Off
Option Explicit On

Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports Microsoft.VisualBasic

Module Variables
	'Déclaration des variables
	
    Public AdresseIP As String
    Public ErreurRemote As Boolean
    Public MessageAEmettre As String
    Public MessageRecu As String
    Public FifoRxD As String
    Public PtLecFifoRxD As Integer
    Public PtEcrFifoRxD As Integer
    Public ErreurTimeout As Boolean
    Public FinReception As Boolean
    Public FinTempo As Boolean
    Public first_connection As Boolean

    'Déclaration des variables TCPIP
    Public Server As TcpListener
    Public Client As TcpClient
    Public cmdImprimante As String
    Public LocalAddr As IPAddress = IPAddress.Any
    Public Stream As NetworkStream

    Public Debut As Integer
    Public Fin As Integer

End Module