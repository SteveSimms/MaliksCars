[] TODO: add form to create/update cars
    1.add method to service 
    2.add create/update form page
    3.call service from page
    4.make form reusable 
[] TODO make CarCard component reusable
[] TODO: add the ability for admins to do crud on cars Create new cars
[] TODO: add the ability to upload images
[] TODO: add the ability to create a wish/watchList

[] TODO: add web scraping to collect car images
[] TODO: work on user account and dashboard pages
[x] TODO: add my self as an admin
[] TODO: add the ability to remove user as an admin
[] TODO: Assign roles via drop down selector?
[] TODO: use geo location to link to users local dealership

[x] TODO: addclick to enlarge function to Details page

[] TODO: create mldotnet model of local dealerships via bing maps or google maps api 


UI
[] TODO: Keep styles basic for now add footer and landing pages
[] TODO: make page responsive

[] TODO: dark/light mode toggle


[] TODO: figure out styling/flowbite integration or other tailwind plugins



//send to notes         @* @user.UserRoles.FirstOrDefault()?.Role.Name *@
                @* @foreach (var userRole in user.UserRoles)
                {
                    <span>@userRole.Role.Name</span>
                } *@