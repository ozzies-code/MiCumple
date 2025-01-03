# FelizCumple

# Descripcion

 Este proyecto consiste en el desarrollo de una aplicacion que emplea
 el objeto DataTiemPicker en Visual Basic.NET para desplegar un calendario
 que proporcionara la fecha en un formato preestablecido por el usuario en
 Visual Basic, y al escoger una fecha en particular y hacer click en un boton,
 se producira un Cuadro de Mensaje que mostrara la fecha seleccionada en una 
 cadena de texto.
 
 # Actualizacion: 03/01/2025
 # Hora: 15:26

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

 # HappyBirthday

# Description

This project involves the development of an application that uses
the DataTiemPicker object in Visual Basic.NET to display a calendar
that will provide the date in a format preset by the user in
Visual Basic, and by choosing a particular date and clicking on a button,
a Message Box will be produced that will display the selected date in a text
string.

# Update: 01/03/2025
# Time: 15:26

Technical details of the project:
Language: Visual Basic.NET
Framework version: 4.7.2

![imagen](https://github.com/user-attachments/assets/b1073863-17b6-4b28-bdaf-1aeecb849184)

Code of the Project:

Public Class frmMicumple
    Private Sub btnDateTime_Click(sender As Object, e As EventArgs) Handles btnDateTime.Click
        MsgBox("Su fecha de cumpleaños es " & DateTimePicker1.Text)
        MsgBox("Día: " &
            DateTimePicker1.Value.DayOfYear.ToString() & " del 2025")
    End Sub
End Class
