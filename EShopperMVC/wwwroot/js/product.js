//const _productId = { "_productId": parseInt(window.location.href.split('=')[1]) };
//console.log(window.location.href);
//$.ajax({
//    url: 'https://localhost:44342/Product/Product',
//    type: 'POST',
//    dataType: 'json',
//    data: _productId,
//    success: function (data) {
//        if (data.productInfos.length > 0) {
//            for (row of data.productInfos) {
//                debugger;

//                var img = row.photo;
//                if (img == undefined) {
//                    img = "default-product.png";
//                }
//                const Photo = ({ img }) => `
//                        <div class="">
//                            <img class="w-100 h-100" src="/productPhotos/${img}" alt="Image">
//                        </div>
//                `;
//                $('.sliderPhotos').append([
//                    {img}
//                ].map(Photo).join(''));
//                document.getElementById("productTitle").innerText = row.name; 
//                document.getElementById("productDesc").innerText = row.description; 
//                document.getElementById("price").innerText = row.price + " TL";
//            }
//        }
//    }
//});
