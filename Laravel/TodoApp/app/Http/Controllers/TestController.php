<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class TestController extends Controller
{
   public function IndexAction(){
    $localname = 'usif';
    $age = 26;
    $Position = 'Software Engineer';
    $data =  [
        'name' => $localname,
        'age' => $age,
        'position' => $Position
    ];
    return view('test', $data);
   }
}
