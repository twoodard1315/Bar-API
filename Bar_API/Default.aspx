﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bar_API._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
  <script type="text/javascript">
      google.charts.load("current", { packages: ['corechart'] });
      google.charts.setOnLoadCallback(drawChart);
      function drawChart() {
          var data = google.visualization.arrayToDataTable(<%=data %>);
          
      /*[
          ["Element", "Density", { role: "style" }],
          ["Copper", 8.94, "#b87333"],
          ["Silver", 10.49, "silver"],
          ["Gold", 19.30, "gold"],
          ["Platinum", 21.45, "color: #e5e4e2"]
        ]*/

          var view = new google.visualization.DataView(data);
          view.setColumns([0, 1,
              {
                  calc: "stringify",
                  sourceColumn: 1,
                  type: "string",
                  role: "annotation"
              },
              2]);

          var options = {
              title: "VA Covid-19 Data",
              width: 600,
              height: 400,
              bar: { groupWidth: "95%" },
              legend: { position: "none" },
          };
          var chart = new google.visualization.ColumnChart(document.getElementById("columnchart_values"));
          chart.draw(view, options);
      }
  </script>
<div id="columnchart_values" style="width: 900px; height: 300px;"></div>
</asp:Content>
