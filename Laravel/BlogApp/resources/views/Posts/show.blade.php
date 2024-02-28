@extends('shared/_Layout')
@section('title' , 'blogs')


@section('content')
    

<div class="row row-cols-1 row-cols-md-3 g-4">

  <div class="col">
    <div class="card h-100">
      <img src="..." class="card-img-top" alt="...">
      <div class="card-body">
        <h5 class="card-title">{{$post->title}}</h5>
        <p class="card-text">{{$post->description }}</p>
        <p class="card-subtext">{{$post->publishat}}</p>
    <div class="d-flex justify-content-between">
    <a href="{{route('show',$post['id'])}}" class="btn btn-warning">View</a>
    <!-- /posts/{{$post['id']}} -->
    <a href="" class="btn btn-secondary">Update</a>
    
    <a href="" class="btn btn-danger " >Delete</a>
    </div>
      </div>
      <div class="card-footer">
        <small class="text-muted">Last updated 3 mins ago</small>
      </div>
    </div>
  </div>

@endsection