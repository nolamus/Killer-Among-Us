-> Scene1
=== Scene1 === 
DUMMY TEXT SCENE 1.
+ [Then, continue.] -> intro


=== intro ===
Boy: Are you the chef?
Chef: Uh, yeah.
+ [What do you know about the drowning incident?] -> why
+ [The lifeguard told me to talk to you.] -> soft


=== soft ===
Chef: Oh, yeah. The lifeguard and I are good friends.
+ [He said to talk to you about the drowning incident.] -> why


=== why ===
Chef: Why do you want to know?
+ [The manager was my mom.] -> begin_story


=== begin_story ===
Chef: Oh. Well, what happened was honestly one of the worst things to happen in my life. I remember how your mom had threatened us. But I'm sure the lifeguard told you all about that.
+ [...] -> Scene2


=== Scene2 ===
DUMMY TEXT SCENE 2.
+ [Then, continue.] -> story


=== story ===
Chef: Truth is...I've always been scared of your mom.
+ [...] -> Scene3


=== Scene3 ===
DUMMY TEXT SCENE 3.
+ [Then, continue.] -> story2


=== story2 ===
Chef: She was blackmailing me for other stuff...stuff I can't go into the details about. But she was just trying to get me to stay working at the hotel.
+ [...] -> story3


=== story3 ===
Chef: Truth is, I really want to open my own restaurant. It's always been my dream.
+ [...] -> story4


=== story4 ===
Chef: Maybe I will finally get the chance now.
+ [...] -> story5


=== story5 ===
Chef: Oh, I am so sorry! I can see how that came off.
+ [...] -> ending
+ [It's fine.] -> soft_temp


=== soft_temp ===
Chef: ...
+ [...] -> ending


=== ending
Chef: Uh, I should get going. Seeya around.
-> END