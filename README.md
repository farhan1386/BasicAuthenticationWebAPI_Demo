# Basic Authentication ASP.NET Web API

### What are Authentication?

Authentication is a process that ensures and confirms a user’s identity.

### What is Authorization?

Authorization is a security mechanism which is used to determine whether the user has access to a particular resource or not. The most point that you need to remember is, authentication happens first, then only authorization.



### Why we need Authentication in Web API?
Let’s start the discussion with one of the Rest Constraint i.e. Stateless Constraint. The Stateless Constraint is one of the Rest Constraints which states that the communication between the client and server must be stateless between the requests. This means that we should not be storing the client information on the server which required to process the request. The request that is coming from the client should contain all the necessary information that is required by the server to process that request. This ensures that each request coming from the client can be treated independently by the server.

### How Basic Authentication Work in Web API?
If a request requires authentication and if the client didn’t send the credentials in the header (most of the time it is Authorization header), then the server will return 401 (Unauthorized). The response will also include a WWW-Authenticate header, indicating that the server supports Basic Authentication.

The client sends another request to the server, with the client credentials in the Authorization header. Generally, the client credentials are formatted as the string “name:password“, base64-encoded format.

As we attach the sensitive data (i,e. username and password) in each and every HTTP request, it should be transferred in an encoded format and the protocol should be HTTPS, then only we can protect our data over the internet.

The ASP.NET Web API Basic Authentication is performed within the context of a “realm.” The server includes the name of the realm in the WWW-Authenticate header. The user’s credentials are valid within that realm. The exact scope of a realm is defined by the server. For example, you might define several realms in order to partition resources.

### Enable Web API Basic Authentication
We can enable basic authentication in many different ways by applying the BasicAuthenticationAttribute. We can apply the BasicAuthenticationAttribute attribute on a specific controller, specific action, or globally on all Web API controllers.

To enable the basic authentication across the entire Web API application, register the BasicAuthenticationAttribute as a filter using the Register() method in WebApiConfig class.

