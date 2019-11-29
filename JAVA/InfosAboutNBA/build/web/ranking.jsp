<%-- 
    Document   : ranking
    Created on : 2019. nov. 29., 12:11:04
    Author     : hp EliteBook
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@page import="controller.*" %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Season Ranking</title>
    </head>
    <body>
        <h1>Season Ranking <br/></h1>
                <form action="CsomagAjanlo" method="get">
            
            
                <%
                    for (TeamCollector csj : CsatornaJelleg.values()) {
                %>
                <option><%= csj.toString()%></option>
                <%
                    }
                %>
            </select><br/>
                %>
 
    </body>
</html>
