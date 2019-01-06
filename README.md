Project Name- pingpongproject

Back End: In this project layered architecture of C# is used and Ms-sql Express database named as  PingpongDB.
Service Layer: 
Service layer of the project has been created in Web API. The context of a layered architecture, it wraps an application and exposes the application functionality in terms of a simple API that the user interface can talk to. 

Ping pong project is divided into 5 sub-projects under main PingPongApp solution.

1.	PingPongApp: Main service layer. This have all the Methods exposed from Players Controller. Such as: 

Tool used: Visual Studio 2017 (C#)


List of All API Calls:
GetPlayers: Returns list of all players from DB

GetSkillLevelList: Returns list of all Skill levels.

GetPlayerById: Return particular player by given ID

AddOrUpdatePlayer: This is POST call for either Adding player or Updating player.

DeletePlayer: This is a DELETE call to delete player from list

2.	PingPongDataEntities:
Enabled Code First Migrations. The Migrations feature enables you to change the data model and deploy your changes to production by updating the database schema without having to drop and re-create the database.

3.	PingPongDataLayer

The data layer manages the physical storage and retrieval of data. Handling all Database interactions from Database.
4.	PingPongServiceLayer
This layer handles interactions between service and the data layer.

5.	PingPongDataLayerTest
This layer, is responsible for the unit tests. 


Front End:
Front end of the application has been created in Angular 6. It is calling Service layer to perform all the CRUD operations. All validations as desired and being applied. 

