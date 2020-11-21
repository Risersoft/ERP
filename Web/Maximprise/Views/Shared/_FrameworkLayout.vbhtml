@imports risersoft.shared.web.Extensions
@imports risersoft.shared.web
@imports risersoft.shared.cloud.common
@imports risersoft.shared.portable
@imports risersoft.shared.cloud
@imports risersoft.shared.agent
@imports risersoft.shared.agent.auth
@Code
    Dim ctx = CType(ViewContext.Controller, IHostedController)
    Dim _user = AuthUtils.GetRSUser(Me.User)

End Code
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewData("Title")</title>
    @Html.RenderJsCss(False, "modernizr", "jquery", "bootstrap", "angular", "ig", "rs")
    @RenderSection("scripts", required:=False)
    @Html.RenderScripts(True, True)
</head>

<body ng-app="rsApp">
    <div id="loading" class="row">
        <div class="col-md-12" id="loading-text">Loading...</div>
    </div>
    @If Not _user Is Nothing Then@<div Class="top-header-navigation" style="height: 27px;">
            <div class="container">

                <div class="btn-group margin-rgt10 navbar navbar-expand-md" style="float:right;margin-right: 22px;">
                    <a class="fa fa-user active" data-toggle="dropdown" style="text-decoration:none;margin-top: 5px;" href="#" aria-expanded="false">
                        <span class="caret"></span>
                    </a>
                    <ul class="dropdown-menu dropdown-men" style="left:-115px;">
                        <li> <a class="dropdown-item" href="/dashboard/admin">Dashboard</a></li>
                        <li> <a class="dropdown-item" href="/account/change">Manage</a></li>
                        <li> <a class="dropdown-item" href="/account/Logout">Logout</a></li>
                    </ul>
                </div>

                <div class="btn-group margin-rgt10 navbar navbar-expand-md" style="float:right;margin-right: 22px;">
                    <a class="" style="text-decoration:none" href="#" aria-expanded="false">
                        Welcome @_user.FullName
                    </a>
                </div>

            </div>
        </div>
    Else
        @<ul Class="header-item">
            <li>
                <a href="@Html.LoginUrl">Login</a>
            </li>
            <li>
                <a href="@Html.SignupUrl">Signup</a>
            </li>
        </ul>
    End If

    @Html.Menu(ctx.myWebController)
    <div class="clsmargn">

        @RenderBody()
        <hr />
        <div id="dialogFilter" title="Filter">
        </div>
        <div id="dialogFilterfile" title="File">
            <div Class="form-group">
                <div Class="col-md-offset-1 col-md-10 " style="margin-top:8px">
                    <input type="file" id="filename" name="filename" Class="form-control" autocomplete="off" accept=".csv,.xls" />
                </div>
            </div>
            <div Class="form-group">
                <div Class="col-md-offset-1 col-md-10 " style="margin-top:8px">
                    <label id="labelid"></label>
                </div>
            </div>
            <div Class="form-group" style="float:right;margin-top:8px">

                <div Class="col-md-12">
                    <input type="button" id="btnSaveFile" value="Save" Class="btn btn-primary" />
                </div>
            </div>
        </div>
        <footer>
            <p><div Class="col-md-3">&copy; @DateTime.Now.Year - @ctx.Host.Brand  </div><div Class="col-md-3">IP: @ctx.myWebController.Police.NetworkIP.ToString</div></p>

        </footer>
    </div>
    <ul id="id_context2" style="display: none;">
        <li data-command="action1">Fetching Data ...</li>
    </ul>

    @RenderSection("BotScripts", required:=False)
    <script type="text/javascript">
        $(document).ready(function () {
            $('.navbar-nav').removeClass('nav');
            $(window).bind('scroll', function () {
                if ($(window).scrollTop() > 69) {
                    $('#treeGrid1_container').addClass('navbar-fixed-top-changeleft');
                    $('#acMainGrid_container').addClass('navbar-fixed-top-changecontent');
                    $('.navbar-fixed-top').addClass('navbar-fixed-top-change');
                    $('.top-line-move').addClass('fixed');
                }
                else {
                    $('#treeGrid1_container').removeClass('navbar-fixed-top-changeleft');
                    $('#acMainGrid_container').removeClass('navbar-fixed-top-changecontent');
                    $('.navbar-fixed-top').removeClass('navbar-fixed-top-change');
                    $('.top-line-move').removeClass('fixed');
                }
            });
        });
    </script>
</body>
</html>
