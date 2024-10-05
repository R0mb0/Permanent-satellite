[![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://github.com/R0mb0/Permanent-satellite)
[![Open Source Love svg3](https://badges.frapsoft.com/os/v3/open-source.svg?v=103)](https://github.com/R0mb0/Permanent-satellite)
[![Donate](https://img.shields.io/badge/PayPal-Donate%20to%20Author-blue.svg)](http://paypal.me/R0mb0)

Urbino`s University - Applied computer science - P.M.O

# P.M.O-Project
Project Title:    Relative system of orientation to permanent satellite.<br>

## Project Specifications:

The project objective is to realize a program that semplify the normal procedures of the tecnique of relative orientation to permanent satellite.<br>
This programm will be able to register the surveys into a database, auomatically create the nodes from each survey, calculate the properties of each nodes, 
represent graphically into a gray map all properties calculated and save into a file the current status of the program.

____
## Project Problems: 

### The problems of this project are:<br>

- #### How to generalize a detection.

A detection is a group of dates that enable to uniquely establish a posiction into the world, in this case the most important dates are the Latitude and the Longitude; 
but in this case there are other important dates, because the goal of this program is keep a track of a route; for this reason is important to insert into a detection: 
the time of the current detection, the angle of the compass and the altitude of the place.<br>
In this way from two detection is possible calculate the travelled distance, the speed and the direction. Particulary the altitude and the compass angle are usefull 
to increase the precision of the dates.<br>
For this reason has been implemented a Point class that permit to track these important dates; in this case for to salve the latitude and the longitude has been introduced 
the Latitude type and the Longitude type, either generating an exception when the information inserted into are wrong.

- #### How to create the nodes that respecting the permanent satellite tecnique.

To solve this problem has been created a specific algoritm that create the nodes in way to every "normal" detection have a node with the  previous detection 
and with the "special" detection.<br>
The "special" detection rappresent the meeting point, the meeting point rappresent the only known point (in sense that this point rappresent the place user knowed); 
in this way is alwais possible have the information to come back towards the meeting point.

- #### How to calculate the node properties.

The Node properties are implemented into the node type, this class contain the detection of the node and the respective properties that are calculate using a GPS standard formulas
.<br>
The Properties of each nodes are: the distance, the speed, the direction, the time/altitude difference. 

- #### How to salve the program status.

The programm status is salved into a doc database, that will be seriallizated using the JSON strategy.

- #### How to create a Graphical User Interface.<br>

The "Gui" is builted using Windows Form, the gui permitt to do a detection, to delete a detecion, to salve the current database status, to load the last database status
and obtain the advanced properties.<br>
Also is possible obtain the status of the program through the gray map (always builted using windows form).

- #### How to rappresent the detections and the nodes into a dinamic grey map.

The gray map goal is to rappresent the nodes and the detections into a scale space where is possible have a idea of the area.<br>
For this reason the gray map must calculate the max/min Latitudes and Longitudes (in indipendent way), in way to determinate the area idea; later this it must rappresent all the detections
and the nodes (in scale compareted to the extremes of the latitudes and longitudes) with the corrispettive properties.<br>
The gray map has been created using Windows Form.

____
## Architectural choices

### Logic And Math classes

The mission durig the "LogicAndMath" class production is to create classes that are riutilizabilies in other ccontest, in way to do this the Latitude and Longitude class extending the 
origin class.<br>
The Origin class has the task to register the fondamental part of a satellite coordinate, this fondamental part is specialized into the Latitude and Longitude class,
in way to no register not compatibilies coordinates.<br>
The Point use the Latitude and Longitude types in way to register a correct posiction, the point is like a detection, for this reason also register the time, the directon,
and the altitude.<br>
The Node use two Point to calculate the properties about the two detection; the properties are calcolated using a external class, the class task is to implement 
the GPS standard formulas.<br>
In this way every class solve only one problem, this permitt the reusability.<br>

![LogicAndMath UML:](https://github.com/RomboUrbex/SatellitePermanente/blob/Report/SatellitePermanente/SatellitePermanente/Report/UML/LogicAndMath_UML.jpg)

### Database Classes
The Database implement the Singleton Pattern (because must exist only one database for contain the dates), the Decorator Pattern (because in the program existing more database version that depending to the functiones) and the Observer (in way to notify the status of the current database into the other part of the program).<br>
The database has been generated in a modular mode, in way to use only the request function, for example: use only the origin database structures in way to serialize the most important dates.<br>
The origin of the database extend the MaxCoordinate class (that contain the Latitude/Longitude extremes) and contain the Point list and the Node list, in way to get the most important dates to serialize.<br>
The second part of the database is named "Normal Database" because this is the official database that make the operation for adding point (and create the corresponding nodes), it work tracking four states of insertion points: 1: when the first added point is a normal point, 2: when the first added point is a meeting point, 3: when the meeting point is added after a list of normal point, 4: when is added a normal point after a meeting point.<br>
The "Normal Database" is used into the "Database With Rescue" to adding the loading and the saving of the current database; the current state of the database is copied into the "Rescue" class, this class has been used for serialize and deserialize the database status using the Json strategy.<br>

![Database UML:](https://github.com/RomboUrbex/SatellitePermanente/blob/Report/SatellitePermanente/SatellitePermanente/Report/UML/Database_UML.jpg)<br>

The Observer Pattern has been implemented using other classes, The "DatabseObserver" class implementing  the subject (in this case the subject observing the current database istance) of the pattern with the possibility to register, remove and updet the observer that are defined through the observer interface; the last class implement the observer interface.<br>

![Observer UML:](https://github.com/RomboUrbex/SatellitePermanente/blob/Report/SatellitePermanente/SatellitePermanente/Report/UML/Observer_UML.jpg)<br>


### Gui Classes
The Gui is formated by a main screen (Named Monitor) that launch the other screen in way to permitt the program action.<br>
The "Monitor" recieve the information by other class in way to complete the action, in fact only the "Monitor" can interact with the database; the other classes passing the information into the monitor unsing a "bridge class" that permit the over comication.<br>

![GUIL:](https://github.com/RomboUrbex/SatellitePermanente/blob/Report/SatellitePermanente/SatellitePermanente/Report/UML/GUI_UML.jpg)<br>

____
## Usage documentation
When the programm is launched the first screen that appear is the main screen where is present the gray map and the buttons for the acctions.<br>
- The Button "Add Point" permitt to do a detection, into the "Add Point" screeen the balck fields are obligatory, the yellow fileds are optional, in case of wrong 
entry going to appear a screen error (with the description of the error).<br>
- The Button "Delete Point" show a table that contain all the inserted detection, choosing the name or the number of the detection and clicking on the delete button is possible to delete a detection.<br>
If into the database there aren`t detection the user is unbale to open the delete point screen.<br>
- The Save Button permitt to salve the current status of the programm. (In case of none detection programm will save a blank file)<br>
- The Load Button loading the last database istance. (afther the loading of the istance is possible to add or delette the detections, then salving other istance of the database).<br>
- The Table button show the tables with the advance dates that not appear into the gray map. (even in this case if there arent detections into the database the user can`t acess into the "Table screen")<br>
____
## Use Cases
Since the program is implemented for a specific problem the use diagram could be too simple, for this reason will be used a discursive version to illustrate the use case.<br>

___

This program was created to solve the problem of orientation into the not mapped placed, in fact the program not permitt other type of uses.<br>
The user should does a detection every twenty minutes (max every half of a hour), in way to have more precision dates (in every time is possible to delete a error detection), the programm going to calculate all the properties that are usefull for the orientation, in case of user perplexity he can whatch the calculated dates.

#### USE CASE
Normal program use
#### ID
UC1
#### ACTOR
User
#### PRECONDITION
- User launch the programm.
#### BASIC COURSE OF EVENTS
1. User do a detection or load the last database.
2. User add a detection or remove a wrong/useless detection.
3. User save the Program status.
#### POSTCONDITION
- User gets all trip properties for every detection.
#### ALTERNATIVE PATHS
1. User use the calculate propterties to sing into a paper map the detections.
2. User use the registered dates to make a map of the place.

____
## Feedback

The program has been survey by some professionist of cartography, they have contributed to the programm checking the correct implementation of the formulas used and the correct rappresentation of the detection into a scales grey map.<br>
In conclusion this programm respect the GPS standard and it could be used how a orientation strument together a professional strument support.

