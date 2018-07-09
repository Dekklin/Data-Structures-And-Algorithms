# Overview
A Graph is a format/design for a collection of similar/related objects. Each Node (object) in the graph has children in which they point to. To traverse through a graph you start at a parent node, and it runs through each of the Nodes that are children of that node, continuing until you hit the bottom.
#Visuals
![Diagram](https://puu.sh/ATDrf/b055e5d88e.png)
![Example](https://puu.sh/ATEmE/634383805e.png)
A Graph is made up of Nodes, Nodes have a value, a list of children nodes, and a boolean called Visited.
Visited is to check if the node has been traversed through or not, since nodes can have as many children as they want, and they can point to nodes that end up pointing in a circle, we need a way to check if the node has been touched by our traversal.
The Children of each Node are the nodes that the parent node can point to/direct the traversal.
A Graph could be used to traverse through a company's employees and employers, employees being children, and employer being the parent node. It also could be used to keep track of a sport's players information like what teams they have been on. Node would be the player, children would be the teams.
