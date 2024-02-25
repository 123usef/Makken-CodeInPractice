<?php

namespace App\Http\Controllers;

use App\Models\Posts;
use Illuminate\Http\Request;
// use ..\..\Models\posts;

class IndexController extends Controller
{
    //here you are able to write your actions 
    // what is the actions --> methods respond to a request 
    // public function Index(){
    //     // get all posts
    //     // $psts = Posts::all();
    //     return view('welcome');
    // }

    public function index(){
        
        $generalposts = [
            ['id' => 1 , 'name' => 'palastininen won inshallah' , 'postedby' => 'adel mahmoud' , 'createdat'=> '00:00:00 2024-08-01' ],
            ['id' => 2 , 'name' => 'egyptions won against bal7a' , 'postedby' => 'ahmed ali ' , 'createdat'=> '00:00:00 2024-04-01' ],
            ['id' => 3 , 'name' => 'yousif mohamed become the Presdient ' , 'postedby' => 'yousif mohamed' , 'createdat'=> '00:00:00 2045-01-01' ],
            ['id' => 4 , 'name' => 'Minister of social health  ' , 'postedby' => 'Mona ' , 'createdat'=> '00:00:00 2028-02-01' ],
        ];
                    //view foldername.Viewname
        return view('Posts.index',['posts' => $generalposts]);
    }
    public function create(){
        

        return view('Posts.create');
    }

    public function store(){
        // $data = $_POST ;
        // $data = Request()->title;
        // $descrition = Request()->description;
        // dd($data , $descrition);


        return to_route('index');
    }
    public function show($postId){

        return 'hello from Detailed Page you have asked for post with id '. $postId;
    }
}
