console.log(window.location.href);


const categoryId = { "_categoryId": window.location.href.split('=')[1] };
debugger;
$.ajax({
    url: "../../Category/Products",
    type: 'POST',
    dataType: 'json',
    data: categoryId,
    success: function (data) {
        debugger;
        if (data) {
            const Item = ({ title, img, price, pricePlus }) => `

                <div class="product col-lg-4 col-md-6 col-sm-12 pb-1">
                    <div class="card product-item border-0 mb-4">
                        <div class="card-header product-img position-relative overflow-hidden bg-transparent border p-0">
                            <img class="img-fluid w-100" src="${img}" alt="">
                        </div>
                        <div class="card-body border-left border-right text-center p-0 pt-4 pb-3">
                            <h6 class="text-truncate mb-3">${title}</h6>
                            <div class="d-flex justify-content-center">
                                <h6>${price} TL</h6><h6 class="text-muted ml-2"><del>${pricePlus} TL</del></h6>
                            </div>
                        </div>
                        <div class="card-footer d-flex justify-content-between bg-light border">
                            <a href="" class="btn btn-sm text-dark p-0"><i class="fas fa-eye text-primary mr-1"></i>İncele</a>
                            <a href="" class="btn btn-sm text-dark p-0"><i class="fas fa-shopping-cart text-primary mr-1"></i>Sepete Ekle</a>
                        </div>
                    </div>
                </div>
                `;
            console.log(data);
            debugger;
            for (row of data) {
                var title = row.name;
                var img = 'https://images.rawpixel.com/image_800/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIyLTExL3BmLXMxMDgtcG0tNDExMy1tb2NrdXAuanBn.jpg';
                var price =  row.price;
                var pricePlus = row.price + 100;
                
                $('#products').append([
                    { title, img, price, pricePlus }
                ].map(Item).join(''));
            }
        }
    }
});
