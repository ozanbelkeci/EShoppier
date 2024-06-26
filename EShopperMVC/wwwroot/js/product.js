const _productId = { "_productId": parseInt(window.location.href.split('=')[1]) };
console.log(window.location.href);
debugger;
$.ajax({
    url: 'https://localhost:44342/Product/Product',
    type: 'POST',
    dataType: 'json',
    data: _productId,
    success: function (data) {
        if (data.productInfos.length>0) {
            console.log(data);
        }
    }
});
