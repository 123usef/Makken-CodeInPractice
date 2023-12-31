/*
    if we want to pass alot of parameters to our function 

    like we want to make a simple calculater that makes sum 
    for user inputs 
    so what if user input is unpredictable 
    we  can use rest parameter
    to collect all user rest input in array 

    function funcname(para1 , para2 , ...rest){

    }


*/

function adding(x , y , ...z)
{
    console.log(x);
    console.log(y);
    console.log(z);
    // before we used something called argument Collections 
    console.log(arguments[0]);  //collections 
    console.log(arguments[1]);  //collection
    console.log(arguments[2]);  //collection
    console.log(arguments)
}

adding(1,2,3,4,5,6,7,8,9); //will return an array 