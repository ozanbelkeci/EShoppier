var navbarCategory = $("#navbar-vertical");

$.ajax({
    url: 'Home/Categories',
    type: 'POST',
    dataType: 'json',
    success: function (data) {
        if (data) {
            debugger;
            console.log(data);
            for (var item of data) {
                var element = '<a href="" class="nav-item nav-link">' + item.name + '</a>';
                navbarCategory.append(element);
            }
        }
    }
});