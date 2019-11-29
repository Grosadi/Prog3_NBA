<%-- 
    Document   : ranking
    Created on : 2019. nov. 29., 12:11:04
    Author     : hp EliteBook
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@page import="controller.TeamController" %>
<%@page import="controller.Team" %>
<%@page import="java.util.ArrayList" %>
        
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Season Ranking</title>
    </head>
    <body>
        <h1>Season Ranking <br/></h1>
        <table>
            <tr>
                <th>Name:</th>
            </tr>
            <c:forEach items="${list}" var="team">
            <tr>
                <td>${team.Name}</td>
            </tr>
            </c:forEach>
        </table>
             
 
    </body>
</html>
