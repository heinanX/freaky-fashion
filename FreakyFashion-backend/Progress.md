# ﻿Record of my progress and thought pattern 

---

# 1. Setup for Local Database --TASK COMPLETED
I needed a local database to use for testing and development purposes. I created models based on the assignment
and a DbContext.

..

# 2. Initial Project Setup --TASK COMPLETED
I set up an initial folder structure and with files neede for a passing grade.
It concludes Products and Categories. I also added some User features, but these are mostly empty files for now.

..

# 3. AutoMapper vs Mapperly = none
To start on task 4, previously task 3, I thought I'd use AutoMapper for my DTOs, unfortunately, you now need a key to use their package,
so I opted out on them. I could use an older version but decided against that because of security risks. I then considered using
Mapperly but taking into consideration the size of the project, I'm just gonna handle the data conversion myself.

..

# 4. Fetch a list of Categories (prev. Products) --TASK COMPLETED
Instead of delving into the Products I thought it better to start with the Categories, as they are both faster and simpler to impletment.
I wanted to test my database connection and the API, so that seemed like the more logical option.

..

# 5. Fetch By Id, Create and Delete a Category --TASK COMPLETED
Generated mappers for both Products and Categories to convert data into Dtos and avoid repetitive code.
Did a test run and everything seems to be working fine.

..

# 6. Create CRUD methods for Product --TASK COMPLETED
Title pretty much says it all. I've successfully implemented CRUD methods for the Product entity. Did a test run and they're all
working as expected with a minor adjustment to the Create method. Instead of serching the database for an exact match
it's now looking for partial matches, making the search function more flexible and user-friendly.


..

# 6. Connect it to Azure for cloud based storage --in progress

.
.
.

---
# todo passing grade requirements:
---

`PRODUCT`

GET /api/products — Fetch a list of products.
GET /api/products/{id} — Fetch a product by ID.
GET /api/products?slug={slug} — Fetch a product by URL slug.
POST /api/products — Create a product.
DELETE /api/products/{id} — Delete a product by ID.

`CATEGORY`

GET /api/categories — Fetch a list of categories. -- check
GET /api/categories/{id} — Fetch a category by ID. -- check
GET /api/categories?slug={slug} — Fetch a category by URL slug. -- TEST RUN LATER
POST /api/categories — Create a category. -- check
DELETE /api/categories/{id} — Delete a category by ID. --check

---
# todo higher grade requirements:
---

`PRODUCT`

GET /api/products[?page=1&pageSize=10] — Fetch a paginated list of products.
GET /api/products/{id} — Fetch a product by ID.
GET /api/products?slug={slug} — Fetch a list of products by URL slug (the list will only contain 0 or 1 product).
POST /api/products — Create a new product.
PATCH /api/products/{id} — Update a product.
DELETE /api/products/{id} — Delete a product by ID.

`CATEGORY`

GET /api/categories — Fetch a list of all categories.
GET /api/categories/{id} — Fetch a category by ID.
GET /api/categories?slug={slug} — Fetch a list of categories by URL slug (the list will only contain 0 or 1 category).
POST /api/categories — Create a new category.
PATCH /api/categories/{id} — Update a category.
DELETE /api/categories/{id} — Delete a category by ID.
DELETE /api/categories/{categoryId}/products/{productId} — Remove a product from a category.

`AUTH`

POST /api/auth/login — Generate a JWT token for login.