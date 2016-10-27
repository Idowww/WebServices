package com.epam.roman.rest;

import java.util.List;

import javax.ws.rs.GET;
import javax.ws.rs.HeaderParam;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;

import com.epam.roman.dao.UserDAO;
import com.epam.roman.dao.impl.UserDAOImpl;
import com.epam.roman.model.User;

@Path("/users")
public class UserRestService {

    @GET
    @Produces({MediaType.APPLICATION_JSON, MediaType.APPLICATION_XML})
    public List<User> getUsers(@HeaderParam("Accept") String acceptHeader) {
		System.out.println("Header: Accept - " + acceptHeader);
    	
        UserDAO userDAO = new UserDAOImpl();
        
        return userDAO.list();
    }
    
    @GET
    @Path("/{id}")
    @Produces(MediaType.APPLICATION_JSON)
    public User getUserInJSON(@PathParam("id") Integer id) {
        UserDAO userDAO = new UserDAOImpl();
        
        return userDAO.get(id);
    }
}