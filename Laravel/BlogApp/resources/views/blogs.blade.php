@extends('shared/_Layout')
@section('title' , 'blogs')


@section('content')
<div>
<table class="table">    
<thead>
        <tr>
            <th scope="col">id</th>
            <th scope="col">name</th>
            <th scope="col">posted by</th>
            <th scope="col">created at </th>
            
        </tr>
    </thead>
    <tbody>
 
        @foreach($posts as $post)
        <tr>
              <td>{{$post['id']}}</td>  
              <td>{{$post['name'] }}</td>  
              <td>{{$post['postedby']}}</td>
              <td>{{$post['postedby']}}</td>  
        </tr>
        @endforeach
    </tbody>
</table>

</div>

@endsection