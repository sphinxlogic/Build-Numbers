Imports System.IO
Imports System.Xml
Module ParsingUsingXmlTextReader
Sub Main()
  Dim m_xmlr As XmlTextReader
  'Create the XML Reader
  m_xmlr = New XmlTextReader("C:\Personal\family.xml")
  'Disable whitespace so that you don't have to read over whitespaces
  m_xmlr.WhiteSpaceHandling = WhiteSpaceHandling.NONE
  'read the xml declaration and advance to family tag
  m_xmlr.Read()
  'read the family tag
  m_xmlr.Read()
  'Load the Loop
  While Not m_xmlr.EOF
    'Go to the name tag
    m_xmlr.Read()
    'if not start element exit while loop
    If Not m_xmlr.IsStartElement() Then
      Exit While
    End If
    'Get the Gender Attribute Value
    Dim genderAttribute = m_xmlr.GetAttribute("gender")
    'Read elements firstname and lastname
    m_xmlr.Read()
    'Get the firstName Element Value
    Dim firstNameValue = m_xmlr.ReadElementString("firstname")
    'Get the lastName Element Value
    Dim lastNameValue = m_xmlr.ReadElementString("lastname")
    'Write Result to the Console
    Console.WriteLine("Gender: " & genderAttribute _
      & " FirstName: " & firstNameValue & " LastName: " _
      & lastNameValue)
    Console.Write(vbCrLf)
  End While
  'close the reader
  m_xmlr.Close()
End Sub
End Module

Public Class Form1

End Class
