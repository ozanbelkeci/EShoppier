console.log(window.location.href);

const categoryId = { "categoryId" : window.location.href.split('=')[1] };

$.ajax({
    url: "../../Category/Products",
    type: 'POST',
    dataType: 'json',
    data: categoryId,
    success: function (data) {
        if (data) {
            console.log(data);
        }
    }
    
});
