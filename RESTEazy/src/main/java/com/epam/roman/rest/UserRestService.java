package com.epam.roman.rest;

import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;

import com.epam.roman.dao.UserDAO;
import com.epam.roman.dao.impl.UserDAOImpl;
import com.google.gson.Gson;

@Path("/users")
public class UserRestService {

	@GET
	@Produces(MediaType.APPLICATION_JSON)
	public Response getUsers() {
		UserDAO userDAO = new UserDAOImpl();

	    String json = new Gson().toJson(userDAO.list());
	    return Response.status(200).entity(json).build();
	}

}