/*
    map is a new datastructure for us in ecma 6 that allow us 
    to store unique key value pair without any redundancy 



*/


var mymap = new Map();
// var mymap = new Map([["one" , "abc"] , [1 ,"xyz"] , [101 , 150]]); // prefered to store the key by string or symbols 
mymap.set("name" , "usif");
mymap
mymap("name" , 'ahmed') ; // will update old value 

mymap.keys();
mymap.entries();
mymap.size();
mymap.delete("one");
mymap.has("one");
mymap.clear();

