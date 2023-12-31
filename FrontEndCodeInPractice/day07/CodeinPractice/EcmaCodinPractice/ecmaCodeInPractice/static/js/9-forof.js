


var arr = [1,2,3,4,5,6,7,8,9];
var obj = {
    name:"yousif" , 
    age : 29 , 
    job : "softwareengineer",
}

for(i in arr) console.log(i) // will output the index 
for(i in arr) console.log(arr[i]) // will output the value  

for(i in obj) console.log(i + " "+ obj[i]) // will output the object key and value 


for(i of arr ){
    console.log(i) // will output the Values 
}

for(i of obj){
    console.log(i);
    // will output an error as object it self is not iterable 
}

var mymap =  new Map([["one" ,"abc"] , [1,"xyyz"] , [101,105]]);


for(i of mymap){
    console.log(i);
}


for(i of mymap.values){
    console.log(i);
}
 

for(i of mymap.keys){
    console.log(i);
}

//destrcturing the map 
for([k , v] of mymap.entries){
    console.log(k +": " + v);
}
 
 