let text = document.getElementById("text")
let message  = 'hello my name is mohamed i am a full stack developer '
let words = message.split(" ");

let index = 0
let interval= setInterval(function(){
text.innerHTML += words[index] + "  ";
index ++
if (index == words.length) {
  clearInterval(interval);
}
}, 500)



