## Project Specifications:

The project objective is to realize a program that semplify the normal procedures of the tecnique of relive orientation to permanent satellite.<br>
This programm will be able to register the surveys into a database, auomatically create the nodes from each survey, calculate the properties of each nodes, 
represent graphically into a gray map all properties calculated and save into a file the current status of the program.

## Project Problems: 

#### The problems of this project are:<br>

- ##### How to generalize a detection.

A detection is a group of dates that allow to uniquely establish a posiction into the world, in this case the most important dates are the Latitude and the longitude; 
but in this case there are other important dates, because the goal of this program is keep a track of a route; for this reason is important to inserto into a detection 
the time of the current detection, the angle of the compass and the altitude of the place.<br>
In this way from two detection is possible calculate the travelled distance, the speed the direction. Particulary the altitude and the compass angle are usefull 
to increase the precision of the calculated dates.<br>
For this reason has been implemented a Point class that permit to track these important dates; in this case for salve the latitude and the longitude has been introduced 
the Latitude type and the Longitude type, both  of types generating an exception when the information inserted are wrong.

- ##### How to create the nodes that respect the permanent satellite tecnique.

To solve this problem has been created a specific algoritm that create the nodes in way to every "normal" detection have a node together the  previous detection 
and together the "special" detection.<br>
The "special" detection rappresent the meeting point, the meeting point rappresent the only known point (in sense that this point rappresent the place user knowed); 
in this way the program calculate the direction to come back into the meeting point.

- ##### How to calculate the node properties.

The Node properties are into the node type, this class contain the detection of the node and the respective properties that are calculate using a GPS standard formulas
.<br>
The Properties of each nodes are: the distance, the speed, the direction, the time/altitude difference. 

- ##### How to salve the program status.

The programm status is salved into a doc database, that succeffully wille be seriallizated using the JSON strategy.

- ##### How to create a Graphical User Interface.<br>

The "Gui" is generated used Windows form, the gui permitt to make a detection, to delete a detecion, to salve the current database status, to load the las database status
and to observe the advanced properties.<br>
Also is possible observe the status of the program through the gray map (always created using windows form).

- ##### How to rappresent the detections and the nodes into a dinamic grey map.

The gray map goal is to rappresent the nodes and the detection into a scale space whwre is possible have a idea where we were.<br>
For this reason the gray map must calculate the max/min Latitudes and Longitudes (in indipendent way), in way to determinate a surface idea; later this it must rappresent all the detections
and the nodes (in scale compareted to the extremes of the latitudes and longitudes) with the corrispettive properties.<br>
The gray map is created using Windows form.

## Architectural choices

##### Logic And Math classes

The objective durig the "LogicAndMath" class production is to create classes that must be riutilizabilies in other ccontest, in way to do this the Latitude and Longitude class extended the 
origin class.<br>
The Origin class has the task to register the fondamental parto of a satellite coordinate, this fondamental part is specialized into the Latitude and Longitude class,
in way to no register not compatibilies coordinates.<br>
The Point use the Latitude and Longitude types in way to register a correct posiction, the point is like a detection, for this reason in register the time, the directon,
and the altitude.<br>
The Node use two point in way to calculate the properties about the two detection; the properties are calcolated using a external class, it`s task is to implement 
all request formula.<br>
In this way every class solve one problem, this fact permit to riulizzable the classes.<br>
![LogicAndMath UML:](https://github.com/RomboUrbex/SatellitePermanente/blob/Report/SatellitePermanente/SatellitePermanente/Report/UML/LogicAndMath_UML.jpg)

##### Database Classes
The Database use the Singleton Pattern (because must exist alwais a database for contain the dates), the Decorator Pattern (because in the program exist more database version depending on the functiones) and the decorator (in way to notify the status if the current database in the other part of the program).<br>
The database has been created in a modular mode, in way to use alwais the request function, for example: using always the database origin structures in way to serialize the most important dates.<br>
The origin of the database is the both of the MaxCoordinate class (that contain the Latitude/Longitude extremes) and the Origin database class (that contain the 
Point list and the node list), in this way is possible to get the most important dates to serialize.<br>
The second part of the database is named "Normal Database" because this is the official database that make the operation for add point (and create the corresponding nodes)



