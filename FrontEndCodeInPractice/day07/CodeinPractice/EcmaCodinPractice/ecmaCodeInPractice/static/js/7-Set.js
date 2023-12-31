/*
    set is an updated datastructure in js 
    that allow you to store unique values in javascript 




*/


var myset  = new Set();
myset.add(1)  ;
myset.add("hola") ; 
myset.add([1,2,3,4,5])
myset.has(1); //return true
myset.has("1"); // return false as one in our set is numaric 

myset.add(1);// will not add as its already hav value 
myset.delete(1);// remove value 1 from our array 
myset.clear() // remove all elements 

var arr = [1,2,3,4,5,6];

myset.add(arr); // will add the array 

myset.entries ; 
myset.values ; 
myset.keys ; 
