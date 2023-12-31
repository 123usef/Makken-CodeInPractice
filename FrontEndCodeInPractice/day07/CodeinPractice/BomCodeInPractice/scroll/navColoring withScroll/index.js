document.addEventListener("scroll", () => {
  const link1 = document.querySelector("#link1");
  const section1 = document.querySelector("#section1");
  const link2 = document.querySelector("#link2");
  const section2 = document.querySelector("#section2");
  const link3 = document.querySelector("#link3");
  const section3 = document.querySelector("#section3");
  if (window.scrollY <= section1.getBoundingClientRect().height) {
    link1.style.color = "red";
    link2.style.color = "black";
    link3.style.color = "black";
  }
 else if (
    window.scrollY > section1.getBoundingClientRect().height &&
    window.scrollY <=
      section2.getBoundingClientRect().height +
        section1.getBoundingClientRect().height
  ) {
    link1.style.color = "black";
    link2.style.color = "red";
    link3.style.color = "black";
  }
 else if (
   window.scrollY >
     section1.getBoundingClientRect().height +
       section2.getBoundingClientRect().height &&
   window.scrollY <=
     section3.getBoundingClientRect().height +
       section2.getBoundingClientRect().height+
       section1.getBoundingClientRect().height
 ) {
   link1.style.color = "black";
   link2.style.color = "black";
   link3.style.color = "red";
 }
});
