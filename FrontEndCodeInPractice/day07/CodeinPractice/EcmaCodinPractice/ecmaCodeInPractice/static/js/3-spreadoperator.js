/*
    spread operator used to combine or spread array element without need 
    to loop over each element 
    also its very helpful for array or object cloning so you can copy the array 
    without refrencing to the main arr

     var  arr = [val1 , val2 , val3 , val4 , val5  ] 

     var  arr1 = [val1 , val2 , val3 , val4 , val5  ] 

     if we want to combine both in arr1 
     arr1 = [val1 , val2 , val3 , val4 , val5 , ...arr ];

     function fullname(fname , lname){
        return fname + '' +lname
     }
     var usrname = ['joe' ,'mohamed']

     instead of 
     fullname(usrname[0] , usrname[1]) ---> X

     we can make 

     fullname(...usrname);

     ------------------------------------------------

     var obj = {
        name:"ali" , 
        age : 25
     }
     var obj2={};
     instead of looping 
     for(i in obj){
        obj2[i] = obj[i];
     }

     we can make 

     var obj2 = {...obj}

     // and it will be two seprated values 


     same for array 

*/

var arr1 = ["orange" , "orange" , "orange" , "orange"  ];
var arr2 = ["mango" , "mango" , "orange"  , ...arr1] ; //combined successfully

function fullname(fname , lname){
    return fname + '' +lname
 }

     var usrname = ['joe' ,'mohamed']

     fullname(...usrname); // spreaded successfully 


     var obj = {
        name:"ali" , 
        age : 25
     }
     var obj2={};
     
     for(i in obj){
        obj2[i] = obj[i];
     }
     obj2 = {...obj};


 var arr3  = [...arr2];     