/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

/**
 *
 * @author hp EliteBook
 */
public class TeamController {

    public List<Team> getTeams() {
        return Teams;
    }

    public void setTeams(List<Team> Teams) {
        this.Teams = Teams;
    }
    public List<Team> Teams;
    
    public TeamController()
    {
    Team team1 = new Team("Boston Celtics");
    Team team2 = new Team("Brooklyn Nets");
    Team team3 = new Team("New York Knicks");
    Team team4 = new Team("Philadelphia 76ers");
    Team team5 = new Team("Toronto Raptors");
    Team team6 = new Team("Chicago Bulls");
    Team team7 = new Team("Cleveland Cavaliers");
    Team team8 = new Team("Detroit Pistons");
    Team team9 = new Team("Indiana Pacers");
    Team team10 = new Team("Milwaukee Bucks");
    Team team11 = new Team("Atlanta Hawks");
    Team team12 = new Team("Charlotte Hornets");
    Team team13 = new Team("Miami Heat");
    Team team14 = new Team("Orlando Magic");
    Team team15 = new Team("Washington Wizards");
    Team team16 = new Team("Dallas Mavericks");
    Team team17 = new Team("Houston Rockets");
    Team team18 = new Team("Memphis Grizzlies");
    Team team19 = new Team("New Orleans Pelicans");
    Team team20 = new Team("San Antonio Spurs"); 
    Team team21 = new Team("Denver Nuggets");
    Team team22 = new Team("Minnesota Timberwolves");
    Team team23 = new Team("Oklahoma City Thunder");
    Team team24 = new Team("Portland Trail Blazers");
    Team team25 = new Team("Utah Jazz");
    Team team26 = new Team("Golden State Warriors");
    Team team27 = new Team("Los Angeles Clippers");
    Team team28 = new Team("Los Angeles Lakers");
    Team team29 = new Team("Phoenix Suns");
    Team team30 = new Team("Sacramento Kings");
        
        this.Teams = new ArrayList();
        Teams.add(team1);
        Teams.add(team2);
        Teams.add(team3);
        Teams.add(team4);
        Teams.add(team5);
        Teams.add(team6);
        Teams.add(team7);
        Teams.add(team8);
        Teams.add(team9);
        Teams.add(team10);
        Teams.add(team11);
        Teams.add(team12);
        Teams.add(team13);
        Teams.add(team14);
        Teams.add(team15);
        Teams.add(team16);
        Teams.add(team17);
        Teams.add(team18);
        Teams.add(team19);
        Teams.add(team20);
        Teams.add(team21);
        Teams.add(team22);
        Teams.add(team23);
        Teams.add(team24);
        Teams.add(team25);
        Teams.add(team26);
        Teams.add(team27);
        Teams.add(team28);
        Teams.add(team29);
        Teams.add(team30);
        
        Teams.sort(Comparator.comparing(Team::getPercentage));     
        
        
    }
    
    
}
