/*
var myIndex = 0;
carousel();

function carousel() {
  var i;
  var x = document.getElementsByClassName("mySlides");
  for (i = 0; i < x.length; i++) {
    x[i].style.display = "none";
  }
  myIndex++;
  if (myIndex > x.length) {
    myIndex = 1;
  }
  x[myIndex - 1].style.display = "block";
  setTimeout(carousel, 5000);
}



document.getElementById("demo").innerHTML =
  new Date("2015-03-25");
*/
document.getElementById('demo').innerHTML = Date();

function apriFinestra1(obj) {
  obj.innerHTML = "Vie"
}

function quidiFinestra1(obj) {
  obj.innerHTML = "<div><img src=\"birth.jpg\" alt=\"HTML tutorial\" style=\"width:80px;height:80px;border:0;\"><p>\"Racontez-nous de sa vie\"</p></div>"
}

function apriFinestra2(obj) {
  obj.innerHTML = "Son Oeuvre"
}

function quidiFinestra2(obj) {
  obj.innerHTML = "<div><img src=\"birth.jpg\" alt=\"HTML tutorial\" style=\"width:42px;height:42px;border:0;\"><p>\"Racontez-nous de sa vie\"</p></div>"
}
