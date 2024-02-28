<?php

namespace App\Http\Controllers\api;

use App\Http\Controllers\Controller;
use App\Models\posts;
use Illuminate\Http\Request;

class PostsApi extends Controller
{
    public function allPosts(){
       
        return posts::all();

    }
    public function getPost($postid){
        $post = posts::findorfail($postid);
        return $post ;
    }
}
