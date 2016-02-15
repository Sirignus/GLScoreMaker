# GLScoreMaker
Logiciel utilisé pour calculer le score lors de races Super Mario Maker.

Les règles de bases sont les suivantes :
Lors d'une race des 100 marios sur Super Mario Maker, un score est attribué à chaque joueur de la race. Ce score varie en fonction du nombre de levels réussis,
de skips et du nombre de morts. Les points pour les morts ne sont comptés que toutes les dix morts ! Toute mort ou skip ne compte que si le score est supérieur à 0 ! (i.e. On ne peut avoir un score négatif).
ATTENTION ! Cette dernière règle est importante, en effet, deux personnes ayant le même nombre de levels réussis, morts et skips peuvent avoir un score différent !
L'ordre est donc extrêmement important ! C'est pourquoi il est FORTEMENT DECONSEILLE d'utiliser le logiciel en milieu de Run ! 
A moins de remettre les points dans le bon ordre !

Les valeurs par défaut sont :
- +10 par level réussi
- -2 par skip
- -5 toutes les 10 morts
  

Raccourcis clavier:
- "Espace" pour ajouter une mort
- "s" pour ajouter un skip
- "l" pour ajouter un level
- CTRL+Z pour annuler la dernière modification
- CTRL+Y pour rétablir la dernière modification

Vous pouvez changez le nombre de points gagnés/perdus pour les morts, skips et level réussis en selectionnant Configuration dans le menu en haut. Cependant, changer ces
valeurs REINITIALISERA le score et les compteurs !

Le logiciel sauvegarde la dernière configuration et la recharge au lancement. Ces informations sont présentes dans le fichier config.xml. Si celui-ci est supprimé par 
mégarde (ou méchanceté pure :( ), il sera recréé au lancement de l'Application avec les valeurs par défaut.

A chaque utilisation du logiciel, un fichier data.txt est créé à l'emplacement du .exe . Celui-ci contient les différentes informations sur le score et les compteurs
dans le but d'être récupérées sur XSplit/OBS pour après les afficher sur un stream.

PROBLEMES : 
Si l'Application ne sauvegarde pas les changements de configuration et ne change pas les valeurs du fichier data.txt, c'est probablement une question de droit d'écriture !
Essayez de lancer l'Application en mode Administrateur ou bien de déplacer tout le dossier dans un endroit ou vous avez tous les droits ! (Par exemple un autre disque que C:)

Si toutefois vous rencontrez d'autres problème ou voulez proposez une modification/amélioration, n'hésitez pas à me joindre sur twitter @Sirignus. 

Bonne race !

Créé par Thomas "Sirignus" Cochat (@Sirignus).

Ce logiciel est utilisable gratuitement par n'importe qui !