var navbarCategory = $("#navbar-cat");

$.ajax({
    url: 'Home/Categories',
    type: 'POST',
    dataType: 'json',
    async: false,
    success: function (data) {
        if (data) {
            console.log(data);
            for (var item of data) {
                var element = '<a class="nav-item nav-link category">' + item.name + '</a>';
                navbarCategory.append(element);
            }
            debugger;
            const my_element = document.getElementsByClassName("category");
            for (row of my_element) {
                row.addEventListener("click", function (e) {
                    debugger;
                    console.log(this.text); // logs the className of my_element
                    console.log(this.className); // logs the className of my_element
                    console.log(e.currentTarget === this); // logs `true`


                    var categoryTitle = this.text;
                    $.ajax({
                        url: 'Category/CategoryFind',
                        type: 'POST',
                        dataType: 'json',
                        data: {categoryTitle :categoryTitle },
                        success: function (result) {
                            if (result.redirectToUrl !== undefined) {
                                window.location.replace(result.redirectToUrl);
                            } else {
                                // No redirect found, do something else
                            }
                        }
                    });
                });
            }
        }
    }
});
