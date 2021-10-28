# Talking with servers

## Async await - GET method using Axios
### Illustration
Creating a website that displays lists of products (Bonsai Trees) from an API route link  

### Html code
```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-F3w7mX95PdgyTmZZMECAngseQB83DfGTowi0iMjiWaeVhAn4FJkqJByhZMI3AhiU" crossorigin="anonymous">
    <script src="https://unpkg.com/axios/dist/axios.min.js"></script>
    <title>Bonsai Trees</title>
</head>
<body>
    <div class="container mt-5 mb-5">
        <h1>Boinsai Plants</h1>
    </div>

    <div class="container mb-5">
        <div class="row">
            <div class="col">
                <img src="" alt="" class="img-fluid rounded" id="image">
                <h3 id="title"></h3>
                <h5 id="price"></h5>
                <p id="description"></p>
                <a href="bonsai-order.html" class="btn btn-dark">Order</a>
            </div>
            <div class="col">
                <img src="" alt="" class="img-fluid rounded" id="image2">
                <h3 id="title2"></h3>
                <h5 id="price2"></h5>
                <p id="description2"></p>
                <a href="bonsai-order.html" class="btn btn-dark">Order</a>
            </div>
            <div class="col">
                <img src="" alt="" class="img-fluid rounded" id="image3">
                <h3 id="title3"></h3>
                <h5 id="price3"></h5>
                <p id="description3"></p>
                <a href="bonsai-order.html" class="btn btn-dark">Order</a>
            </div>
        </div>
    </div>

    <script src="bonsai.js"></script>
</body>
</html>
```

### JS code
```JS
async function getTrees(){
    try {
        let trees = await axios.get('https://tbhpwebdevapi.azurewebsites.net/api/Bonsai')

        document.getElementById("title").innerHTML = trees.data[0].productTitle; 
        document.getElementById("price").innerHTML = "Price: N" + trees.data[0].productPrice;
        document.getElementById("description").innerHTML = trees.data[0].productDescription;
        document.getElementById("image").src = "https://project1-bonsai-jacobtimms.vercel.app/" + trees.data[0].productImage;


        document.getElementById("title2").innerHTML = trees.data[1].productTitle; 
        document.getElementById("price2").innerHTML = "Price: N" + trees.data[1].productPrice;
        document.getElementById("description2").innerHTML = trees.data[1].productDescription;
        document.getElementById("image2").src = "https://project1-bonsai-jacobtimms.vercel.app/" + trees.data[1].productImage;


        document.getElementById("title3").innerHTML = trees.data[2].productTitle; 
        document.getElementById("price3").innerHTML = "Price: N" + trees.data[2].productPrice;
        document.getElementById("description3").innerHTML = trees.data[2].productDescription;
        document.getElementById("image3").src = "https://project1-bonsai-jacobtimms.vercel.app/" + trees.data[2].productImage;
    } catch (err) {
        console.error(err)
    }
}

getTrees()
```

## Talking with servers using form data
### Illustration

### Html code
```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-F3w7mX95PdgyTmZZMECAngseQB83DfGTowi0iMjiWaeVhAn4FJkqJByhZMI3AhiU" crossorigin="anonymous">
    <script src="https://unpkg.com/axios/dist/axios.min.js"></script>
    <title>Bonsai Trees</title>
</head>
<body>
    <div class="container mt-5 mb-5">
        <h1>Place an order now</h1>
    </div>

    <div class="container mb-5">
        <form action="https://tbhpwebdevapi.azurewebsites.net/api/Order/simple/save/usingFormData" method="POST">
            <div class="row mb-3">
                <div class="col">
                    <input type="number" name="id" class="form-control" placeholder="id" id="id">
                </div>
                <div class="col">
                    <input type="text" name="clientName" class="form-control" placeholder="Your name" id="clientName">
                </div>
                <div class="col">
                    <input type="number" name="qty" class="form-control" placeholder="Quantity" id="qty">
                </div>
            </div>
            <div class="row mb-3">
                <div class="col">
                    <input type="text" name="productName" class="form-control" placeholder="Product name" id="productName">
                </div>
                <div class="col">
                    <input type="number" name="productPrice" class="form-control" placeholder="Price" id="productPrice">
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <button class="btn btn-dark">Order</button>
                </div>
            </div>
        </form>
    </div>
</body>
</html>
```