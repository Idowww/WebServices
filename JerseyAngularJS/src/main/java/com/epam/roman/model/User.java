package com.epam.roman.model;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;

@Entity
@Table(name = "users")
@XmlRootElement(name = "user")
@XmlAccessorType(XmlAccessType.FIELD)
public class User {
	@Id
	@GeneratedValue
	@Column(name = "id")
	private Integer id;
	
	@Column(name = "login")
	private String login;
	
	@Column(name = "epam_id")
	private Integer epamId;
	
	@Column(name = "is_deleted")
	public Boolean deleted;
	
	@Column(name = "level_id")
	private Integer levelId;
	
	@Column(name = "location_id")
	private Long locationId;
	
	@Column(name = "manager_id")
	private Integer managerId;
	
	@Column(name = "upsa_id")
	private Long upsaId;

	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	public String getLogin() {
		return login;
	}

	public void setLogin(String login) {
		this.login = login;
	}

	public Integer getEpamId() {
		return epamId;
	}

	public void setEpamId(Integer epamId) {
		this.epamId = epamId;
	}

	public Boolean isDeleted() {
		return deleted;
	}

	public void setDeleted(Boolean deleted) {
		this.deleted = deleted;
	}

	public Integer getLevelId() {
		return levelId;
	}

	public void setLevelId(Integer levelId) {
		this.levelId = levelId;
	}

	public Long getLocationId() {
		return locationId;
	}

	public void setLocationId(Long locationId) {
		this.locationId = locationId;
	}

	public Integer getManagerId() {
		return managerId;
	}

	public void setManagerId(Integer managerId) {
		this.managerId = managerId;
	}

	public Long getUpsaId() {
		return upsaId;
	}

	public void setUpsaId(Long upsaId) {
		this.upsaId = upsaId;
	}
}