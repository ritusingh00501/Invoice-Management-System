<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication8.Views.login" %>



<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">

    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <link rel="stylesheet" href="../css/style.css">
    <script>
			function validateform()
			{
				var name=document.myform.user_id.value;
				var password=document.myform.password.value;
				if(name=null || name=="")
				{
					alert("Name can't be blank");
					return false;
				}
				else if(password.length<6)
				{
					alert("Password must be at least 6 characters long.");
					return false;
				}
			}
    </script>

    <title>Login</title>
</head>
<body>
		<div class="bg-img">
      <div class="container">
        <div class="box form-box">
                        <header>Admin Login</header>
            <form name=myform onsubmit="return validateform()" runat="server">
                <div class="field input">
                    <label for="Email">User Name</label>
                    <asp:TextBox id="user_id" runat="server" TextMode="Email"></asp:TextBox><br />
            
                </div>

                <div class="field input">
                    <label for="password">Password</label>
                    <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox><br />
            
                </div>

                <div class="field">
                               <!-- <div class="row" aria-selected="undefined">
<asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>
 <br></br>
 </div>-->
                  <asp:Button Text="Login" runat="server" CssClass="btn-success btn" ID="submitbutton" OnClick="submitbutton_Click"/>
                   <!-- <input type="submit" id=submitButton class="btn" name="submit" value="Login" required>-->
                 </div>
                <div class="links">
                    Don't have account? <a href="register.aspx">Register Now</a>
                </div>
		<div class=links>
			<a href="solution.html">Back</a>
			</div>

            </form>
        </div>
      </div>
      </div>
      </body>
</html>
