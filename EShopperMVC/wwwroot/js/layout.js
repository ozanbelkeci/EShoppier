var navbarCategory = $("#navbar-cat");
function createPage() {

    $.post("/Home/redirectUri", function (data) {
        alert(data);
    });  
    //debugger;
    //const _urlName = { "viewName": "hakkimizda" };
    //$.ajax({
    //    url: 'https://localhost:44342/Home/CreateLandingPage',
    //    type: 'POST',
    //    dataType: 'json',
    //    data: _urlName,
    //    success: function (result) {
    //        if (result.redirectToUrl !== undefined) {
    //            window.location.replace(result.redirectToUrl);
    //        } else {
    //            // No redirect found, do something else
    //        }
    //    }
    //});
}
debugger;
function getCookie(cname) {
    let name = cname + "=";
    let decodedCookie = decodeURIComponent(document.cookie);
    let ca = decodedCookie.split(';');
    for (let i = 0; i < ca.length; i++) {
        let c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}
var cookie = getCookie("Categories");
if (cookie != '') {
    var data = JSON.parse(getCookie("Categories"))
    console.log(data);
    for (var item of data) {
        var element = `<a href="Category?_categoryId=${item.Id}" class="nav-item nav-link category">${item.Name}</a>`;
        navbarCategory.append(element);
    }
}
else {
    $.ajax({
        /*    url: 'Home/Categories',*/
        url: "https://localhost:44342/Home/Categories",
        type: 'POST',
        dataType: 'json',
        success: function (data) {
            if (data) {
                console.log(data);
                for (var item of data) {
                    var element = `<a href="Category?_categoryId=${item.id}" class="nav-item nav-link category">${item.name}</a>`;
                    navbarCategory.append(element);
                }
                //const my_element = document.getElementsByClassName("category");
                //for (row of my_element) {
                //    row.addEventListener("click", function (e) {
                //        console.log(this.text); // logs the className of my_element
                //        console.log(this.className); // logs the className of my_element
                //        console.log(e.currentTarget === this); // logs `true`
                //    });
                //}
            }
        }
    });
}

