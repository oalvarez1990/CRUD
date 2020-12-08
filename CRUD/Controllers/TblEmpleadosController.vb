Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports CRUD

Namespace Controllers
    Public Class TblEmpleadosController
        Inherits System.Web.Mvc.Controller

        Private db As New Empresa1Entities

        ' GET: TblEmpleados
        Function Index() As ActionResult
            Return View(db.TblEmpleados.ToList())
        End Function

        ' GET: TblEmpleados/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblEmpleados As TblEmpleados = db.TblEmpleados.Find(id)
            If IsNothing(tblEmpleados) Then
                Return HttpNotFound()
            End If
            Return View(tblEmpleados)
        End Function

        ' GET: TblEmpleados/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: TblEmpleados/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID,Nombres,Apellidos")> ByVal tblEmpleados As TblEmpleados) As ActionResult
            If ModelState.IsValid Then
                db.TblEmpleados.Add(tblEmpleados)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tblEmpleados)
        End Function

        ' GET: TblEmpleados/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblEmpleados As TblEmpleados = db.TblEmpleados.Find(id)
            If IsNothing(tblEmpleados) Then
                Return HttpNotFound()
            End If
            Return View(tblEmpleados)
        End Function

        ' POST: TblEmpleados/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID,Nombres,Apellidos")> ByVal tblEmpleados As TblEmpleados) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tblEmpleados).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tblEmpleados)
        End Function

        ' GET: TblEmpleados/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblEmpleados As TblEmpleados = db.TblEmpleados.Find(id)
            If IsNothing(tblEmpleados) Then
                Return HttpNotFound()
            End If
            Return View(tblEmpleados)
        End Function

        ' POST: TblEmpleados/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tblEmpleados As TblEmpleados = db.TblEmpleados.Find(id)
            db.TblEmpleados.Remove(tblEmpleados)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
