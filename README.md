Understanding the REST pattern.

GET:
  GET is used to fetch resources from a collection. GET requests are idempotent so any amount of requests will produce identical results. 
  GET returns an HTTP 200 (Ok) status is successful, if not, it will return a 404 status.
  
POST:
  POST is often used when adding data to a resource collection. Use POST when performing CREATE actions. POST is not idempotent. 
  Successful POSTs result in an HTTP 201 status.
  
PUT:
  PUT is used when attempting to modify a resource. If the resource is not found, then CREATE actions are performed, if the resource is found, 
  then it will be replaced with the new data. PUT is idempotent. 
  A successful will request will return a 200 or 204 status, depending on if the resource was created or updated. 
  Failed PUTs result in 405 (Method not allowed) or 404 (Not Found) statuses.
  
DELETE:
  DELETE is obviously used to remove resources. If the request was successful, than the resource is gone, and calling the request repeatedly will not change anything, 
  making DELETE requests idempotent. DELETEs return a 200 or 404 if successful, else, a 405 status.
  
PATCH:
  PATCH is used to make updates on a resource. This differs from PUT in that it will not replace the resource, but simply update the specified values. 
  PATCH is idempotent because it will only update the specified values once until a different request is sent. 
  So if a request is sent and it needs to change the value of 'name' from { 'name' : 'Ichiro' } to { 'name' : 'Jim }, 
  it will update the value on the first successful request, and keep the value on all subsequent requests until a new value is specified. 
  Similar to PUT, successful PATCHes return a 200 or 204 responses, failed PATCHes return a 405 or 404 status.
