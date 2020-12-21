## Project Specifications:

The project objective is to realize a program that semplify the normal procedures of the tecnique of relive orientation to permanent satellite.<br>
This programm will be able to register the surveys into a database, auomatically create the nodes from each survey, calculate the properties of each nodes, 
represent graphically into a gray map all properties calculated and save into a file the current status of the program.

## Project Problems: 

### The problems of this project are:<br>

- #### How to generalize a detection.

A detection is a group of dates that enable to uniquely establish a posiction into the world, in this case the most important dates are the Latitude and the longitude; 
but in this case there are other important dates, because the goal of this program is keep a track of a route; for this reason is important to insert into a detection: 
the time of the current detection, the angle of the compass and the altitude of the place.<br>
In this way from two detection is possible calculate the travelled distance, the speed and the direction. Particulary the altitude and the compass angle are usefull 
to increase the precision of the dates.<br>
For this reason has been implemented a Point class that permit to track these important dates; in this case for salve the latitude and the longitude has been introduced 
the Latitude type and the Longitude type, both  of types generating an exception when the information inserted are wrong.

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

The "Gui" is builted used Windows Form, the gui permitt to make a detection, to delete a detecion, to salve the current database status, to load the last database status
and obtain the advanced properties.<br>
Also is possible obtain the status of the program through the gray map (always builted using windows form).

- #### How to rappresent the detections and the nodes into a dinamic grey map.

The gray map goal is to rappresent the nodes and the detections into a scale space where is possible have a idea of the area.<br>
For this reason the gray map must calculate the max/min Latitudes and Longitudes (in indipendent way), in way to determinate the area idea; later this it must rappresent all the detections
and the nodes (in scale compareted to the extremes of the latitudes and longitudes) with the corrispettive properties.<br>
The gray map has been created using Windows Form.

## Architectural choices

### Logic And Math classes

The mission durig the "LogicAndMath" class production is to create classes that must be riutilizabilies in other ccontest, in way to do this the Latitude and Longitude class extending the 
origin class.<br>
The Origin class has the task to register the fondamental part of a satellite coordinate, this fondamental part is specialized into the Latitude and Longitude class,
in way to no register not compatibilies coordinates.<br>
The Point use the Latitude and Longitude types in way to register a correct posiction, the point is like a detection, for this reason also register the time, the directon,
and the altitude.<br>
The Node use two point in way to calculate the properties about the two detection; the properties are calcolated using a external class, it`s task is to implement 
the GPS formulas.<br>
In this way every class solve one problem in way to be riulizzable in other contest.<br>

![LogicAndMath UML:](https://github.com/RomboUrbex/SatellitePermanente/blob/Report/SatellitePermanente/SatellitePermanente/Report/UML/LogicAndMath_UML.jpg)

### Database Classes
The Database implement the Singleton Pattern (because must exist only one database for contain the dates), the Decorator Pattern (because in the program existing more database version that depending to the functiones) and the decorator (in way to notify the status of the current database in the other part of the program).<br>
The database has been generated in a modular mode, in way to use only the request function, for example: use only the origin database structures in way to serialize the most important dates.<br>
The origin of the database extend the MaxCoordinate class (that contain the Latitude/Longitude extremes) and contain the Point list and the Node list, in this way is possible to get the most important dates to serialize.<br>
The second part of the database is named "Normal Database" because this is the official database that make the operation for add point (and create the corresponding nodes), it work tracking four states of insertion: 1: when the first added point is a normal point, 2: when the first added point is a meeting point, 3: when the meeting point is added after a list of normal point, 4: when is added a normal point after a meeting point.<br>
The normal database is used from the database with rescue for adding the loading and the saving of the current database; the current state of the database is copied into the rescue class, this class wille be used for serialize and deserialize the database status using the Json strategy.<br>

![Database UML:](https://github.com/RomboUrbex/SatellitePermanente/blob/Report/SatellitePermanente/SatellitePermanente/Report/UML/Database_UML.jpg)<br>

The Observer Pattern has been implemented using other classes, The "DatabseObserver" class implementing  the subject (observing the current database istance) of the pattern with the possibility to register, remove and updet the observer that are defined through the observer interface; the last class implement the observer interface.<br>

![Observer UML:](https://github.com/RomboUrbex/SatellitePermanente/blob/Report/SatellitePermanente/SatellitePermanente/Report/UML/Observer_UML.jpg)<br>


### Gui Classes
The Gui is formated by a main Form (Named Monitor) that launch the other Form in way to do the program action.<br>
The monitor recieve the information by other class in way to complete the action, in fact only the monitor can interact with the database; the other classes passing the information to the monitor unsing a "bridge class" that permit the comication over the forms.<br>

![GUIL:](https://github.com/RomboUrbex/SatellitePermanente/blob/Report/SatellitePermanente/SatellitePermanente/Report/UML/GUI_UML.jpg)<br>

## Usage documentation
When the programm is launched the first screen that appear is the main screen where is present the gray map and the buttons for the acction.<br>
The Button "Add Point" permitt to make a detection, into the "add point" screeen the balck fields are obligatory, the yellow fileds are optional, in case of wrong 
entry going to appear a screen error (with the description of the error).<br>
The Button "Delete Point" show a table that contain all the inserted detection, choosing the name or the number of the detection and clicking on the delete button is possible delete a dtection.<br>
If into the database there aren`t detection the user is unbale to open the delete point screen.<br>
The Save Button permitt to salve the current status of the programm. (In case of none detection programm will save a blank file)<br>
The Load Button loading the last database istance. (afther the loading of the istance is possible to add or delette the detections, then salving other istance of the database).<br>
The Table button show the tables with the advance dates that not appear into the gray map.<br>
