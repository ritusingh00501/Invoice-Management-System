<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApplication8.Views.register" %>

<!DOCTYPE html>

<html lang="en" dir="ltr">
  <head>
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
    <meta charset="UTF-8">
    <link rel="stylesheet" href="../css/style1.css">
     <meta name="viewport" content="width=device-width, initial-scale=1.0">
   </head>
<body>
	
  <div class="container">
    <div class="title">Registration</div>
    <div class="content">
      <form name=myform  onsubmit="return validateform()" method=post runat="server">
        <div class="user-details">
          <div class="input-box">
            <span class="details">Username</span>
            <input type="text" name=user_id placeholder="Enter your username" id="userid" runat="server" required>
          </div>
     
          <div class="input-box">
            <span class="details">Password</span>
            <input type="password" name=password placeholder="Enter your password" id="psw" runat="server" required>
          </div>
         
	</div>
                        <div class="field">
                                <div class="row" aria-selected="undefined">
<asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>
 <br></br>
 </div>
                  <asp:Button Text="Register" runat="server" CssClass="btn-success btn" ID="registerbutton" OnClick="registerbutton_Click"/>
                   <!-- <input type="submit" id=submitButton class="btn" name="submit" value="Login" required>-->
                 </div>
      </form>
    </div>
  </div>

</body>
</html>

