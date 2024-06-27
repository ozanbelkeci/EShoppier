const categoryId = { "_categoryId": window.location.href.split('=')[1] };
console.log(window.location.href);

//$.ajax({
//    url: "https://localhost:44342/Category/Products",
//    type: 'POST',
//    dataType: 'json',
//    data: categoryId,
//    success: function (data) {
//        if (data) {
//            const Item = ({ id,title, img, price, pricePlus }) => `

//                <div class="product col-lg-4 col-md-6 col-sm-12 pb-1">
//                    <div class="card product-item border-0 mb-4">
//                        <div class="card-header product-img position-relative overflow-hidden bg-transparent border p-0">
//                            <img style="height: 300px !important; padding-left:10px !important;" class="productReview img-fluid w-100" src="/productPhotos/${img}" alt="">
//                            <input class="productId" style="display:none;" value="${id}"/>
//                        </div>
//                        <div class="card-body border-left border-right text-center p-0 pt-4 pb-3">
//                            <h6 class="text-truncate mb-3">${title}</h6>
//                            <div class="d-flex justify-content-center">
//                                <h6>${price} TL</h6><h6 class="text-muted ml-2"><del>${pricePlus} TL</del></h6>
//                            </div>
//                        </div>
//                        <div class="card-footer d-flex justify-content-between bg-light border">
//                        <div>
//                            <a class="productReview btn btn-sm text-dark p-0"><i class="fas fa-eye text-primary mr-1"></i>İncele</a>
//                            <input class="productId" style="display:none;" value="${id}"/>
//                            <a href="" class="btn btn-sm text-dark p-0"><i class="fas fa-shopping-cart text-primary mr-1"></i>Sepete Ekle</a>
//                        </div>
//                    </div>
//                </div>
//                `;
//            console.log(data);
//            debugger;
//            for (row of data) {
//                var title = row.name;
//                var img;
//                if (row.photo != null)
//                    img = row.photo;
//                else {
//                    img = "default-product.png";
//                }
//                var price =  row.price;
//                var pricePlus = row.price + 100;
//                var id = row.id;

                
//                $('#products').append([
//                    {id, title, img, price, pricePlus }
//                ].map(Item).join(''));
//            }
//            $(".productReview").on('click', function (event) {
//                debugger;
//                var productId = parseInt($(event.currentTarget).closest("div").children()[1].value);
//                debugger;
//                $.ajax({
//                    url: 'https://localhost:44342/Product/ProductDetail',
//                    type: 'POST',
//                    dataType: 'json',
//                    success: function (result) {
//                        if (result.redirectToUrl !== undefined) {
//                            document.location.replace(result.redirectToUrl + "?_productId=" + productId);
//                            //window.location.replace(result.redirectToUrl + "?_productId=" + productId);
//                        } else {
//                            // No redirect found, do something else
//                        }
//                    }
//                });
//            });

//        }
//    }
//});
