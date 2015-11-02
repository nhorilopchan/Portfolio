<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Mine.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="cycle">
        <h2 class="text-center">Easy panoramic headers: <small>drag mouse around on image</small></h2>
    </div>
    <!-- /.cycle -->
    <div class="container">
        <div class="row">

            <br>
            <br>
            <br>
            <hr>
            <p>Cyclotron project:<a href="https://github.com/mahonnaise/cyclotron" target="_blank">https://github.com/mahonnaise/cyclotron</a></p>
            <p><small>Image by <a href="http://www.flickr.com/photos/smyph/" target="_blank">smyph.</a></small></p>
            <p><small>Cursor by <a href="https://www.iconfinder.com/icons/80532/finger_flick_gestureworks_one_icon" target="_blank">Gestureworks_one.</a></small></p>
            <hr>
            <p>
                <br>
                <a href="http://validator.w3.org/check?uri=http%3a%2f%2fbootsnipp.com%2fiframe%2f6pxr;ss=1"><span class="glyphicon glyphicon-check" style="color: #339900;"></span><small>HTML</small><sup>5</sup></a>
            </p>

        </div>
        <!-- /.row -->
    </div>
    <!-- /.container -->
    <div class="col-lg-12 col-sm-12 profile-page">
        <div class="card hovercard">
            <div class="card-background">
                <img class="card-bkimg" alt="" src="http://lorempixel.com/100/100/people/9/">
                <!-- http://lorempixel.com/850/280/people/9/ -->
            </div>
            <div class="useravatar">
                <img alt="" src="http://lorempixel.com/100/100/people/9/">
            </div>
            <div class="card-info">
                <span class="card-title">Pamela Anderson</span>

            </div>
        </div>
        <div class="btn-pref btn-group btn-group-justified btn-group-lg" role="group" aria-label="...">
            <div class="btn-group" role="group">
                <button type="button" id="stars" class="btn btn-primary" href="#tab1" data-toggle="tab">
                    <span class="glyphicon glyphicon-star" aria-hidden="true"></span>
                    <div class="hidden-xs">Stars</div>
                </button>
            </div>
            <div class="btn-group" role="group">
                <button type="button" id="favorites" class="btn btn-default" href="#tab2" data-toggle="tab">
                    <span class="glyphicon glyphicon-heart" aria-hidden="true"></span>
                    <div class="hidden-xs">Favorites</div>
                </button>
            </div>
            <div class="btn-group" role="group">
                <button type="button" id="following" class="btn btn-default" href="#tab3" data-toggle="tab">
                    <span class="glyphicon glyphicon-user" aria-hidden="true"></span>
                    <div class="hidden-xs">Following</div>
                </button>
            </div>
        </div>

        <div class="well">
            <div class="tab-content">
                <div class="tab-pane fade in active" id="tab1">
                    <h3>This is tab 1</h3>
                </div>
                <div class="tab-pane fade in" id="tab2">
                    <h3>This is tab 2</h3>
                </div>
                <div class="tab-pane fade in" id="tab3">
                    <h3>This is tab 3</h3>
                </div>
            </div>
        </div>

    </div>


</asp:Content>
