
# Company Contacts API Documentation

## Introduction

Welcome to the Company Contacts API. This API is designed for managing companies, contacts, and countries. It provides functionalities to create, retrieve, update, and delete information related to these entities.

## API Endpoints

### Company Endpoints

#### 1. Get All Companies
- **Endpoint:** `GET /api/company`
- **Description:** Retrieves a list of all companies.
- **Response Code:** 200 OK

#### 2. Get Company by ID
- **Endpoint:** `GET /api/company/{companyId}`
- **Description:** Retrieves a specific company by its ID.
- **Response Codes:** 200 OK, 404 Not Found

#### 3. Create Company
- **Endpoint:** `POST /api/company`
- **Description:** Creates a new company.
- **Response Codes:** 201 Created, 400 Bad Request

#### 4. Update Company
- **Endpoint:** `PUT /api/company/{companyId}`
- **Description:** Updates an existing company.
- **Response Codes:** 204 No Content, 400 Bad Request, 404 Not Found

#### 5. Delete Company
- **Endpoint:** `DELETE /api/company/{companyId}`
- **Description:** Deletes a specific company.
- **Response Codes:** 204 No Content, 404 Not Found

### Contact Endpoints

#### 1. Get All Contacts
- **Endpoint:** `GET /api/contact`
- **Description:** Retrieves a list of all contacts.
- **Response Code:** 200 OK

#### 2. Get Contact by ID
- **Endpoint:** `GET /api/contact/{contactId}`
- **Description:** Retrieves a specific contact by its ID.
- **Response Codes:** 200 OK, 404 Not Found

#### 3. Get Contacts with Details
- **Endpoint:** `GET /api/contact/details`
- **Description:** Retrieves contacts with detailed information.
- **Response Code:** 200 OK

#### 4. Filter Contacts
- **Endpoint:** `GET /api/contact/filter`
- **Description:** Retrieves contacts filtered by country or company.
- **Parameters:** `countryId`, `companyId`
- **Response Code:** 200 OK

#### 5. Add Contact
- **Endpoint:** `POST /api/contact`
- **Description:** Adds a new contact.
- **Response Codes:** 201 Created, 400 Bad Request

#### 6. Update Contact
- **Endpoint:** `PUT /api/contact/{contactId}`
- **Description:** Updates an existing contact.
- **Response Codes:** 200 OK, 400 Bad Request, 404 Not Found

#### 7. Delete Contact
- **Endpoint:** `DELETE /api/contact/{contactId}`
- **Description:** Deletes a specific contact.
- **Response Codes:** 204 No Content, 404 Not Found

### Country Endpoints

#### 1. Get All Countries
- **Endpoint:** `GET /api/country`
- **Description:** Retrieves a list of all countries.
- **Response Code:** 200 OK

#### 2. Get Country by ID
- **Endpoint:** `GET /api/country/{countryId}`
- **Description:** Retrieves a specific country by its ID.
- **Response Codes:** 200 OK, 404 Not Found

#### 3. Add Country
- **Endpoint:** `POST /api/country`
- **Description:** Adds a new country.
- **Response Codes:** 201 Created, 400 Bad Request

#### 4. Update Country
- **Endpoint:** `PUT /api/country/{countryId}`
- **Description:** Updates an existing country.
- **Response Codes:** 200 OK, 400 Bad Request, 404 Not Found

#### 5. Delete Country
- **Endpoint:** `DELETE /api/country/{countryId}`
- **Description:** Deletes a specific country.
- **Response Codes:** 204 No Content, 404 Not Found

## Usage Instructions
Keep in mind to change the connection string when using on your machine.
To use the API, send HTTP requests to the specified endpoints. For POST and PUT requests, include the necessary data in the request body. Use appropriate IDs and parameters as required for each endpoint.


