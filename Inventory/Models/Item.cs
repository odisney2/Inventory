/*
    Orris Disney II
    C# Inventory Project
    July 2018
    
    Definition of a Model
    The model represents the data, and does nothing else. The model does NOT depend on the controller or the view. 
    The view displays the model data, and sends user actions (e.g. button clicks) to the controller.

    This is for the the Item part of the project.    This is where you setup what data we are gathering for the Item class.   
    I set up the one to many relationship to the ItemType here  
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public int ItemTypeId { get; set; }             /* to setup one to many relationship with ItemType */
        public string DisplayName { get; set; }
        public string ItemNotes { get; set; }
        public virtual ItemType ItemType { get; set; }  /* to setup one to many relationship with ItemType */
    }
}