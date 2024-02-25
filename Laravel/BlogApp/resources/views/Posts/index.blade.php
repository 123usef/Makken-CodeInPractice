@extends('shared/_Layout')
@section('title' , 'blogs')


@section('content')
<div>
    <a href="{{route('create')}}" class="btn btn-primary">Create New Post </a>

 
    <div class="row row-cols-1 row-cols-md-3 g-4">
        @foreach($posts as $post)
  <div class="col">
    <div class="card h-100">
      <img src="..." class="card-img-top" alt="...">
      <div class="card-body">
        <h5 class="card-title">{{$post['id']}}</h5>
        <p class="card-text">{{$post['name'] }}</p>
        <p class="card-subtext">{{$post['postedby']}}</p>
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
  

  
  @endforeach
  
</div>
</div>

@endsection