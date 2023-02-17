function include(arr,obj) {
    return (arr.indexOf(obj) != -1);
}

document.addEventListener('click', function(e) {
  if (e.target.id == "errordot") {
  	var sun = document.getElementById('errorsun');
    // var classes = sun.className.split(" ");
    if (sun.className == "orbit") {
    	var bodyRect = document.body.getBoundingClientRect(),
      elemRect = e.target.getBoundingClientRect(),
      y_pos = elemRect.top - bodyRect.top,
      x_pos = elemRect.left - bodyRect.left;
      e.target.style.backgroundColor = 'green';
      sun.className = "";
    	sun.style.left = x_pos+'px';
      sun.style.top = y_pos+'px';
      }
      else {
      	sun.setAttribute('class', 'orbit');
        e.target.style.backgroundColor = 'yellow';
      }
    }
});


