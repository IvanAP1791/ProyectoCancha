<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Presentacion.aspx.cs" Inherits="Presentacion.Presentacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="container">
	<div class="row">
		<div class="col-md-6">
			<h3>
				Formulario de clientes
			</h3>
			
				<div class="form-group">
					 
					<label for="exampleInputEmail1">
						Email address
					</label>
					<input type="email" class="form-control" id="exampleInputEmail1" />
				</div>
				<div class="form-group">
					 
					<label for="exampleInputPassword1">
						Password
					</label>
					<input type="password" class="form-control" id="exampleInputPassword1" />
				</div>
				<div class="form-group">
					 
				</div> 
				<button type="submit" class="btn btn-primary">
					Submit
				</button>
			</form>
		</div>
	</div>
</div>

    <%--<div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <h3 class="panel-title">Panel 1</h3>
                        <span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
                    </div>
                    <div class="panel-body">
                        <div class="row">

                           

                            <p class="bg-success" style="padding: 10px; margin-top: 20px; clear: both"><small><a href="http://css-tricks.com/float-labels-css/" target="_blank">Link</a> to original article</small></p>
                        </div>
                    </div>
                </div>
            </div>--%>
    <%--</div>--%>
    <%--</div>--%>


    <script type="text/javascript">
        $(document).on('click', '.panel-heading span.clickable', function (e) {
            var $this = $(this);
            if (!$this.hasClass('panel-collapsed')) {
                $this.parents('.panel').find('.panel-body').slideUp();
                $this.addClass('panel-collapsed');
                $this.find('i').removeClass('glyphicon-chevron-up').addClass('glyphicon-chevron-down');
            } else {
                $this.parents('.panel').find('.panel-body').slideDown();
                $this.removeClass('panel-collapsed');
                $this.find('i').removeClass('glyphicon-chevron-down').addClass('glyphicon-chevron-up');
            }
        })
    </script>


</asp:Content>
