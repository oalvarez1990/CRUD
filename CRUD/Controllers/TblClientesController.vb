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
    Public Class TblClientesController
        Inherits System.Web.Mvc.Controller

        Private db As New Empresa1Entities2

        ' GET: TblClientes
        Function Index() As ActionResult
            Return View(db.TblCliente.ToList())
        End Function

        ' GET: TblClientes/Details/5
        Function Details(ByVal id As Decimal) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblCliente As TblCliente = db.TblCliente.Find(id)
            If IsNothing(tblCliente) Then
                Return HttpNotFound()
            End If
            Return View(tblCliente)
        End Function

        ' GET: TblClientes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: TblClientes/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID_Cliente,Nombre_Cliente,Direccion,Pais,FechaPedido,Cupo")> ByVal tblCliente As TblCliente) As ActionResult
            If ModelState.IsValid Then
                db.TblCliente.Add(tblCliente)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tblCliente)
        End Function

        ' GET: TblClientes/Edit/5
        Function Edit(ByVal id As Decimal) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblCliente As TblCliente = db.TblCliente.Find(id)
            If IsNothing(tblCliente) Then
                Return HttpNotFound()
            End If
            Return View(tblCliente)
        End Function

        ' POST: TblClientes/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID_Cliente,Nombre_Cliente,Direccion,Pais,FechaPedido,Cupo")> ByVal tblCliente As TblCliente) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tblCliente).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tblCliente)
        End Function

        ' GET: TblClientes/Delete/5
        Function Delete(ByVal id As Decimal) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblCliente As TblCliente = db.TblCliente.Find(id)
            If IsNothing(tblCliente) Then
                Return HttpNotFound()
            End If
            Return View(tblCliente)
        End Function

        ' POST: TblClientes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Decimal) As ActionResult
            Dim tblCliente As TblCliente = db.TblCliente.Find(id)
            db.TblCliente.Remove(tblCliente)
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
