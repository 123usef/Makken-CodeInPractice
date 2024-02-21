<!-- resources/views/layout.blade.php -->
<!DOCTYPE html>
<html>
<head>
    <title>@yield('title')</title>
    <!-- Include your common CSS and JS files here -->
</head>
<body>
    @yield('content')
</body>
</html>
----------------------------------------------------

<!-- resources/views/welcome.blade.php -->
@extends('layout')

@section('title', 'Welcome')

@section('content')
    <div>
        <h1>Welcome to our website!</h1>
        <!-- Your content goes here -->
    </div>
@endsection

----------------------------------------------------------
 @include('partials.header')