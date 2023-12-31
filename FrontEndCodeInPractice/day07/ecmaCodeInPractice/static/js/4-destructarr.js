/*
    spread operators is very helpful for assign and declare in one step without 
    care about array indexing 
    suppose you have arr 
    var  arr = [val1 , val2 , val3 , val4 , val5  ] 
    var x =arr[0];  
    var y =  arr[1];
    var z =  arr[2];


    That will destruct  the first three values of the array into thos 3 variables 
    
    var [x,y,z] = arr  
    also we can set default values if not found 

    var [x,y=0,z] = arr
    value of y will be zero if not found in the original array   


    also we can use spread operator to spread the rest of values into array 
    the spread has to be the last element 
    var [x,y,z ,...w] = arr  

   ----------------------------------------------------
   we can also destruct to an object 
    var o = {} ; 
    var [o.x,o.y,o.z ,...(o.w)] = arr  

    ------------------------------------object destructing --------------------------------
    var obj {
        name : "es6",
        main : "javascript" , 
        born : 2015
    }
    we can destruct what we need 
    var {name:x , 
        main : y } = obj;
     var {name:x , 
        main : y,
        born } = obj; 
        that will save the value of born in an variable called born 
    
*/
var  arr = [1 , 2 , 3 , 4 , 4 ] ; 

    var [x,y,z] = arr  
    console.log(x);
    console.log(y);
    console.log(z);
    
    var [x,y=0,z] = arr

    console.log(x);
    console.log(y);
    console.log(z);
    var [x,y,z ,...w] = arr  
    console.log(x);
    console.log(y);
    console.log(z);
    console.log(w);

    //destructing array into object 
    var x,y,z ;
    var o = {} ; 
     [o.x
        ,o.y,
        o.z,
        ...(o.w)] = arr  ;


        var obj =  {
            name : "es6",
            main : "javascript" , 
            born : 2015
        }
         
        var {name: x , 
            main : y , 
        born } = obj;


        console.log(x);
        console.log(y);
        console.log(born);