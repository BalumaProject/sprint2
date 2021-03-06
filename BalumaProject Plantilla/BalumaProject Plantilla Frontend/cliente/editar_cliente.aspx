﻿<%@ Page Language="C#" MasterPageFile="~/cliente/Cliente.Master" AutoEventWireup="true" CodeBehind="editar_cliente.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.cliente.editar_cliente" %>

<%@ Register TagPrefix="uc" TagName="Footer" Src="~/_footer.ascx"  %>
<%@ MasterType VirtualPath="~/cliente/Cliente.Master" %>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        (function () {

            // Create input element for testing
            var inputs = document.createElement('input');

            // Create the supports object
            var supports = {};

            supports.autofocus = 'autofocus' in inputs;
            supports.required = 'required' in inputs;
            supports.placeholder = 'placeholder' in inputs;

            // Fallback for autofocus attribute
            if (!supports.autofocus) {

            }

            // Fallback for required attribute
            if (!supports.required) {

            }

            // Fallback for placeholder attribute
            if (!supports.placeholder) {

            }

            // Change text inside send button on submit
            var send = document.getElementById('register-submit');
            if (send) {
                send.onclick = function () {
                    this.innerHTML = '...Sending';
                }
            }

        })();
		</script>
        <form id="Form1" runat="server">
        
    <div class="registration_left">
        <div class="registration_form ">
		 <!-- Form -->
			
           <div class = "editar-foto">
        <img src="../Content/images/perfil.jpg" alt=""/>
        </div>
        <div class ="editar-foto_buscar">
         <asp:FileUpload ID="FileUpload1" runat="server"/>
         </div>
            
           <div>
					<label>
						<asp:TextBox ID = "nickname" type="text" tabindex="0" placeholder="Nombre de usuario:" runat = "server"  />
					</label>
				</div>
			
				<div>
					<label>
						<asp:TextBox ID = "nombre" type="text" tabindex="1" placeholder="Nombre:" runat = "server"  />
					</label>
				</div>
				<div>
					<label>
						<asp:TextBox ID = "papellido" type="text" tabindex="2" placeholder="Primer apellido:" runat = "server" />
					</label>
				</div>

				<div>
					<label>
						<asp:TextBox ID = "sapellido" placeholder="Segundo apellido:" type="text" tabindex="3" runat="server" />
					</label>
				</div>

				
				<div>
					<label>
						<asp:TextBox ID = "email" placeholder="Email:" type="email" tabindex="4" runat="server" />
					</label>
				</div>

                	
				                	
				<div>
					<label>
						<asp:TextBox ID = "local" placeholder="localidad:" type="text" tabindex="6" runat="server" />
					</label>
				</div>

                <div>
					<label>
						<asp:TextBox ID = "cp" placeholder="C.P:" type="text" tabindex="7" runat="server" />
					</label>
				</div>
                	
				<div>
					<label>
						<asp:TextBox ID = "telf" placeholder="número de teléfono:" type="text" tabindex="8" runat="server" />
					</label>
				</div>

                	
				<div>
					<label>
						<asp:TextBox ID = "cuenta" placeholder="cuenta bancaria:" type="text" tabindex="9" runat="server" />
					</label>
				</div>

				<div>
					<label>
						<asp:TextBox ID = "pass" placeholder="contraseña" type="password" tabindex="10" runat="server" />
					</label>
				</div>						
				<div>
					<label>
						<asp:TextBox ID="TextBox1" placeholder="repite la contraseña" type="password" tabindex="11" runat="server" />
					</label>
				</div>	
				<div class="boton-edicion_cliente">
					<asp:Button OnClick = "editar"  text="Actualiza tus datos"  runat="server"/>
				</div>
                <div class="boton-baja">
                    <asp:Button OnClick = "baja" text="Dar de baja"  runat = "server" />
                </div>

                
			
			<!-- /Form -->
		</div>
       
    </div>
     
     
    </form>
    



   <uc:Footer id="footer"
        runat="server" />

</asp:Content>
