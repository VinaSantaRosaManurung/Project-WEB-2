<%@ Page Language="VB" AutoEventWireup="false" CodeFile="daftar.aspx.vb" Inherits="daftar" %>


<!DOCTYPE html>
<html lang="en">
<head runat="server">
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta http-equiv="X-UA-Compatible" content="ie=edge">
	<title>Pustaka Wilayah | Daftar</title>

	<link rel="stylesheet" href="https://colorlib.com/etc/regform/colorlib-regform-7/fonts/material-icon/css/material-design-iconic-font.min.css">

	<link rel="stylesheet" href="https://colorlib.com/etc/regform/colorlib-regform-7/css/style.css">
</head>
<body>
	<div class="main">

		<section class="signup">
			<div class="container">
				<div class="signup-content">
					<div class="signup-form">
						<h2 class="form-title">Daftar</h2>
						<form class="register-form" id="form1" runat="server">
							<div class="form-group">
								<label for="nama"><i class="zmdi zmdi-account material-icons-name"></i></label>
                                <asp:TextBox ID="nama" runat="server" type="text" placeholder="Nama" required="true"></asp:TextBox>
							</div>
							<div class="form-group">
								<label for="email"><i class="zmdi zmdi-email"></i></label>
                                <asp:TextBox ID="email" runat="server" type="text" placeholder="Email" required="true"></asp:TextBox>
							</div>
							<div class="form-group">
								<label for="pass"><i class="zmdi zmdi-lock"></i></label>
                                <asp:TextBox ID="password" runat="server" type="password" placeholder="Password" required="true"></asp:TextBox>
							</div>
							<div class="form-group">
								<label for="hp"><i class="zmdi zmdi-phone"></i></label>
                                <asp:TextBox ID="no_hp" runat="server" type="number" placeholder="No Hp" required="true"></asp:TextBox>
							</div>
							<div class="form-group form-button">
                                 <asp:Button ID="regis" CssClass="form-submit" runat="server" name="regis" Text="Daftar"/>
							</div>
						</form>
					</div>
					<div class="signup-image">
						<figure><img src="https://colorlib.com/etc/regform/colorlib-regform-7/images/signup-image.jpg" alt="sing up image"></figure>
						<p>Sudah memiliki akun? <a href="masuk.aspx">Masuk</a></p>
					</div>
				</div>
			</div>
		</section>
	</div>

	<script src="https://colorlib.com/etc/regform/colorlib-regform-7/vendor/jquery/jquery.min.js" type="c268eb648de928ea2f108f1c-text/javascript"></script>
	<script src="https://colorlib.com/etc/regform/colorlib-regform-7/js/main.js" type="c268eb648de928ea2f108f1c-text/javascript"></script>

	<script async src="https://www.googletagmanager.com/gtag/js?id=UA-23581568-13" type="c268eb648de928ea2f108f1c-text/javascript"></script>
	<script type="c268eb648de928ea2f108f1c-text/javascript">
		window.dataLayer = window.dataLayer || [];
		function gtag(){dataLayer.push(arguments);}
		gtag('js', new Date());

		gtag('config', 'UA-23581568-13');
	</script>
	<script src="https://ajax.cloudflare.com/cdn-cgi/scripts/7089c43e/cloudflare-static/rocket-loader.min.js" data-cf-settings="c268eb648de928ea2f108f1c-|49" defer=""></script></body>
	</html>
