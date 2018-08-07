-- Portals are our list of clients. The table is:
Select p.portal_id, p.portal_nm from u_portal p order by p.portal_nm

-- Portals can have multiple Courses. The table for courses is:
select cp.course_portal_id, cp.course_portal_nm from u_course_portal cp where cp.portal_id = 1 -- will show only courses for specific client
order by cp.course_portal_nm

-- Courses can be registered to by users. The table for registrations is:
select r.registration_id, r.user_id, r.course_portal_id, 
r.registration_dttm
from 	u_registration r
order by r.registration_dttm

-- The table for users is:
select u.user_id, u.first_nm, u.last_nm
from 	u_user u
order by  u.last_nm, u.first_nm
