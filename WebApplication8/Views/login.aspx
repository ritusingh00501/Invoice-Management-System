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
            <form name=myform onsubmit="return validateform()">
                <div class="field input">
                    <label for="email">Email</label>
                    <input type="text" name="user_id" id="user_id" autocomplete="off" required>
                </div>

                <div class="field input">
                    <label for="password">Password</label>
                    <input type="password" name="password" id="password" autocomplete="off" required>
                </div>

                <div class="field">
                    
                    <input type="submit" id=submitButton class="btn" name="submit" value="Login" required>
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
